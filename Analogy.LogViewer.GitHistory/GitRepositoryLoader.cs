using Analogy.Interfaces;
using Analogy.LogViewer.GitHistory.Managers;
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Analogy.LogViewer.GitHistory
{
    public class GitRepositoryLoader : IAnalogyRealTimeDataProvider
    {
        private  RepositorySetting RepositorySetting { get; }

        public GitRepositoryLoader(RepositorySetting rs)
        {
            RepositorySetting = rs;
        }

        public Task InitializeDataProviderAsync(IAnalogyLogger logger)
        {
            LogManager.Instance.SetLogger(logger);
            return Task.CompletedTask;
        }

        public void MessageOpened(AnalogyLogMessage message)
        {
            //nop
        }

        public Guid ID { get; } = new Guid("407C8AD7-E7A3-4B36-9221-BB5D48E78766");
        public string OptionalTitle  => RepositorySetting.RepositoryPath;
        public Task<bool> CanStartReceiving() => Task.FromResult(true);

        public void StartReceiving()
        {
            try
            {

                using (var repo = new Repository(RepositorySetting.RepositoryPath))
                {
                    var RFC2822Format = "ddd dd MMM HH:mm:ss yyyy K";

                    IEnumerable<Commit> commits;
                    if (RepositorySetting.FetchType == FetchType.Count)
                        commits = repo.Commits.Take(RepositorySetting.NumberOfCommits);
                    else if (RepositorySetting.FetchType == FetchType.DateTime)
                        commits = repo.Commits.Where(c => c.Author.When >= RepositorySetting.HistoryDateTime);
                    else
                        commits = new List<Commit>(0);

                    foreach (Commit c in commits)
                    {
                        AnalogyLogMessage m = new AnalogyLogMessage
                        {
                            Date = c.Author.When.DateTime,
                            Module = RepositorySetting.RepositoryPath,
                            Source = c.Id.Sha,
                            Text =
                                $"{(c.Parents.Any() ? $"{c.Message} Merge: {string.Join(" ", c.Parents.Select(p => p.Id.Sha.Substring(0, 7)).ToArray())}" : c.Message)}",
                            User =
                                $"Committer: {c.Committer.Name} ({c.Committer.Email}). Author: {c.Author.Name} ({c.Author.Email})",
                            FileName = c.Id.Sha,
                            Category = c.Tree.FirstOrDefault()?.Name,
                            Level = AnalogyLogLevel.Event,
                            Class = AnalogyLogClass.General
                        };
                        OnMessageReady?.Invoke(this, new AnalogyLogMessageArgs(m, "", "", ID));

                    }
                }
            }
            catch (Exception e)
            {
                LogManager.Instance.LogError(nameof(StartReceiving), $@"Error reading {RepositorySetting.RepositoryPath}: {e}");
            }

        }


        public void StopReceiving()
        {
            //nop
        }

        public IAnalogyOfflineDataProvider FileOperationsHandler { get; } = null;
        public bool IsConnected { get; } = true;
        public event EventHandler<AnalogyDataSourceDisconnectedArgs> OnDisconnected;
        public event EventHandler<AnalogyLogMessageArgs> OnMessageReady;
        public event EventHandler<AnalogyLogMessagesArgs> OnManyMessagesReady;
    }
}
