﻿using Analogy.Interfaces;
using Analogy.LogViewer.GitHistory.Managers;
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Analogy.LogViewer.GitHistory.Data_Types;

namespace Analogy.LogViewer.GitHistory
{
    public class GitRepositoryLoader : IAnalogyRealTimeDataProvider
    {
        public Guid Id { get; } = new Guid("3CD8B586-5AB0-4C84-A1F8-0F093F846A5D");
        public Image ConnectedLargeImage { get; } = null;
        public Image ConnectedSmallImage { get; } = null;
        public Image DisconnectedLargeImage { get; } = null;
        public Image DisconnectedSmallImage { get; } = null;
        public string OptionalTitle => RepositorySetting.RepositoryPath;
        public Task<bool> CanStartReceiving() => Task.FromResult(true);
        public IAnalogyOfflineDataProvider FileOperationsHandler { get; } = null;
        public event EventHandler<AnalogyDataSourceDisconnectedArgs> OnDisconnected;
        public event EventHandler<AnalogyLogMessageArgs> OnMessageReady;
        public event EventHandler<AnalogyLogMessagesArgs> OnManyMessagesReady;
        private RepositorySetting RepositorySetting { get; }
        private GitOperationType Operation { get; }
        public bool UseCustomColors { get; set; } = false;
        public IEnumerable<(string originalHeader, string replacementHeader)> GetReplacementHeaders()
            => new List<(string originalHeader, string replacementHeader)> { ("Source", "Branch"), ("Process/Module", "Local Path") };

        public (Color backgroundColor, Color foregroundColor) GetColorForMessage(IAnalogyLogMessage logMessage)
            => (Color.Empty, Color.Empty);
        public GitRepositoryLoader(RepositorySetting rs, GitOperationType operation)
        {
            RepositorySetting = rs;
            Operation = operation;
        }

        public Task InitializeDataProviderAsync(IAnalogyLogger logger)
        {
            LogManager.Instance.SetLogger(logger);
            return Task.CompletedTask;
        }

        public void MessageOpened(AnalogyLogMessage message)
        {
            //noop
        }

        public Task StartReceiving()
        {
            try
            {
                switch (Operation)
                {
                    case GitOperationType.History:
                        GetGitHistory();
                        break;
                    case GitOperationType.Fetch:
                        PerformGitFetch();
                        break;
                    case GitOperationType.Merge:
                        break;
                    case GitOperationType.Pull:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception e)
            {
                LogManager.Instance.LogError(nameof(StartReceiving),
                    $@"Error reading {RepositorySetting.RepositoryPath}: {e}");
                AnalogyLogMessage m = new AnalogyLogMessage
                {
                    Date = DateTime.Now,
                    Module = RepositorySetting.RepositoryPath,
                    Text = $"Error: {e}",
                    Level = AnalogyLogLevel.Error,
                    Class = AnalogyLogClass.General
                };
                OnMessageReady?.Invoke(this, new AnalogyLogMessageArgs(m, "", "", Id));

            }
            return Task.CompletedTask;
        }

        private void GetGitHistory()
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
                        Source = repo.Head.FriendlyName,
                        Text =
                            $"{(c.Parents.Any() ? $"{c.Message} Merge: {string.Join(" ", c.Parents.Select(p => p.Id.Sha.Substring(0, 7)).ToArray())}" : c.Message)}" + $" (Committer: {c.Committer.Name})",
                        User =
                            $"Committer: {c.Committer.Name} ({c.Committer.Email}). Author: {c.Author.Name} ({c.Author.Email})",
                        FileName = c.Id.Sha,
                        Category = c.Tree.FirstOrDefault()?.Name,
                        Level = (c.Committer.Name == c.Author.Name) ? AnalogyLogLevel.Event : AnalogyLogLevel.Warning,
                        Class = AnalogyLogClass.General
                    };
                    OnMessageReady?.Invoke(this, new AnalogyLogMessageArgs(m, "", "", Id));

                }
            }
        }

        private void PerformGitFetch()
        {
            using (var repo = new Repository(RepositorySetting.RepositoryPath))
            {
                var remote = repo.Network.Remotes["origin"];
                var refSpecs = remote.FetchRefSpecs.Select(x => x.Specification);
                Commands.Fetch(repo, remote.Name, refSpecs, null, "");


                var trackingBranch = repo.Head.TrackedBranch;
                var commits = repo.Commits.QueryBy(new CommitFilter
                { IncludeReachableFrom = trackingBranch.Tip.Id, ExcludeReachableFrom = repo.Head.Tip.Id });

                foreach (Commit c in commits)
                {
                    AnalogyLogMessage m = new AnalogyLogMessage
                    {
                        Date = c.Author.When.DateTime,
                        Module = RepositorySetting.RepositoryPath,
                        Source = c.Id.Sha,
                        Text = $"Incoming: {c.Committer.Name}:{c.Message}",
                        User =
                            $"Committer: {c.Committer.Name} ({c.Committer.Email}). Author: {c.Author.Name} ({c.Author.Email})",
                        FileName = c.Id.Sha,
                        Category = c.Tree.FirstOrDefault()?.Name,
                        Level = AnalogyLogLevel.Event,
                        Class = AnalogyLogClass.General
                    };
                    OnMessageReady?.Invoke(this, new AnalogyLogMessageArgs(m, "", "", Id));

                }
            }
        }
        public Task StopReceiving() => Task.CompletedTask;

    }
}
