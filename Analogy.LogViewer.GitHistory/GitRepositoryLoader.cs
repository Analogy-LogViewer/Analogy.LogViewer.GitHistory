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
        public string OptionalTitle { get; } = string.Empty;
        public Task<bool> CanStartReceiving() => Task.FromResult(true);

        public void StartReceiving()
        {
            if (!UserSettingsManager.UserSettings.RepositoriesSetting.Repositories.Any())
            {
                AnalogyLogMessage m = new AnalogyLogMessage("No Repositories exist to query", AnalogyLogLevel.Error, AnalogyLogClass.General, "");
                OnMessageReady?.Invoke(this, new AnalogyLogMessageArgs(m, "", "", ID));
                return;
            }

            foreach (RepositorySetting rs in UserSettingsManager.UserSettings.RepositoriesSetting.Repositories)
            {
                try
                {

                    using (var repo = new Repository(rs.RepositoryPath))
                    {
                        var RFC2822Format = "ddd dd MMM HH:mm:ss yyyy K";

                        IEnumerable<Commit> commits;
                        if (rs.FetchType == FetchType.Count)
                            commits = repo.Commits.Take(15);
                        else if (rs.FetchType == FetchType.DateTime)
                            commits = repo.Commits.Where(c => c.Author.When >= rs.HistoryDateTime);
                        else
                            commits = new List<Commit>(0);

                        foreach (Commit c in commits)
                        {
                            AnalogyLogMessage m = new AnalogyLogMessage
                            {
                                Date = c.Author.When.DateTime,
                                Module = rs.RepositoryPath,
                                Source = $"{c.Author.Name} ({c.Author.Email})",
                                Text =
                                    $"{c.Id.Sha}{(c.Parents.Any() ? $"{c.Message} Merge: {string.Join(" ", c.Parents.Select(p => p.Id.Sha.Substring(0, 7)).ToArray())}" : c.Message)}",
                                User = $"{c.Committer.Name} ({c.Committer.Email})",
                                FileName = rs.RepositoryPath,
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
                    LogManager.Instance.LogError(nameof(StartReceiving), $@"Error reading {rs.RepositoryPath}: {e}");
                }

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
