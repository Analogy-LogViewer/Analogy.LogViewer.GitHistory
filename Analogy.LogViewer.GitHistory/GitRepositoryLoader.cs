using Analogy.Interfaces;
using Analogy.Interfaces.DataTypes;
using Analogy.Interfaces.WinForms;
using Analogy.LogViewer.GitHistory.DataTypes;
using Analogy.LogViewer.Template.Managers;
using LibGit2Sharp;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Analogy.LogViewer.GitHistory
{
    public class GitRepositoryLoader : Template.OnlineDataProviderWinForms
    {
        public override Guid Id { get; set; } = new Guid("3CD8B586-5AB0-4C84-A1F8-0F093F846A5D");
        public override Image? ConnectedLargeImage { get; set; }
        public override Image? ConnectedSmallImage { get; set; }
        public override Image? DisconnectedLargeImage { get; set; }
        public override Image? DisconnectedSmallImage { get; set; }
        public override string OptionalTitle { get; set; }
        public override Task<bool> CanStartReceiving() => Task.FromResult(true);

        public override IAnalogyOfflineDataProviderWinForms FileOperationsHandler { get; set; }

        private RepositorySetting RepositorySetting { get; }
        private GitOperationType Operation { get; }
        public override bool UseCustomColors { get; set; }
        public override IEnumerable<(string OriginalHeader, string ReplacementHeader)> GetReplacementHeaders()
            => new List<(string OriginalHeader, string ReplacementHeader)> { ("Source", "Branch"), ("Module", "Local Path") };

        public override (Color BackgroundColor, Color ForegroundColor) GetColorForMessage(IAnalogyLogMessage logMessage)
            => (Color.Empty, Color.Empty);
        public GitRepositoryLoader(RepositorySetting rs, GitOperationType operation)
        {
            RepositorySetting = rs;
            Operation = operation;
            OptionalTitle = RepositorySetting.RepositoryPath;
        }

        public override Task InitializeDataProvider(ILogger logger)
        {
            return base.InitializeDataProvider(logger);
        }

        public override Task StartReceiving()
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
                LogManager.Instance.LogError(e, $@"Error reading {RepositorySetting.RepositoryPath}: {e}", nameof(StartReceiving));
                AnalogyLogMessage m = new AnalogyLogMessage
                {
                    Date = DateTimeOffset.Now,
                    Module = RepositorySetting.RepositoryPath,
                    Text = $"Error: {e}",
                    Level = AnalogyLogLevel.Error,
                    Class = AnalogyLogClass.General,
                };
                MessageReady(this, new AnalogyLogMessageArgs(m, "", "", Id));
            }
            return Task.CompletedTask;
        }

        public override Task ShutDown() => Task.CompletedTask;

        private void GetGitHistory()
        {
            using (var repo = new Repository(RepositorySetting.RepositoryPath))
            {
                var RFC2822Format = "ddd dd MMM HH:mm:ss yyyy K";
                IEnumerable<Commit> commits;
                IEnumerable<Tag> tags;
                if (RepositorySetting.FetchType == FetchType.Count)
                {
                    commits = repo.Commits.Take(RepositorySetting.NumberOfCommits);
                    tags = repo.Tags.Take(RepositorySetting.NumberOfTags);
                }
                else if (RepositorySetting.FetchType == FetchType.DateTime)
                {
                    commits = repo.Commits.Where(c => c.Author.When >= RepositorySetting.HistoryDateTime);
                    tags = repo.Tags.Where(t => t.Annotation == null || t.Annotation.Tagger.When >= RepositorySetting.HistoryDateTime);
                }
                else
                {
                    commits = new List<Commit>(0);
                    tags = new List<Tag>(0);
                }

                foreach (Commit c in commits)
                {
                    AnalogyLogMessage m = new AnalogyLogMessage
                    {
                        Date = c.Author.When,
                        Module = RepositorySetting.RepositoryPath,
                        Source = repo.Head.FriendlyName,
                        Text =
                            $"{(c.Parents.Any() ? $"{c.Message} Merge: {string.Join(" ", c.Parents.Select(p => p.Id.Sha.Substring(0, 7)).ToArray())}" : c.Message)}" + $" (Committer: {c.Committer.Name} [{c.Committer.Email}], Author: {c.Author.Name} [{c.Author.Email}])",
                        User = $"Committer: {c.Committer.Name} ({c.Committer.Email}). Author: {c.Author.Name} ({c.Author.Email})",
                        FileName = c.Id.Sha,
                        Level = (c.Committer.Name == c.Author.Name) ? AnalogyLogLevel.Information : AnalogyLogLevel.Warning,
                        Class = AnalogyLogClass.General,
                    };
                    m.AddOrReplaceAdditionalProperty("Category", c.Tree.FirstOrDefault()?.Name);
                    MessageReady(this, new AnalogyLogMessageArgs(m, "", "", Id));
                }
                foreach (Tag t in tags)
                {
                    var c = t.Target as Commit;
                    AnalogyLogMessage m = new AnalogyLogMessage
                    {
                        Date = c.Author.When,
                        Module = RepositorySetting.RepositoryPath,
                        Source = repo.Head.FriendlyName,
                        Text =
                            $"TAG: {t.FriendlyName}. {(c.Parents.Any() ? $"{c.Message} Merge: {string.Join(" ", c.Parents.Select(p => p.Id.Sha.Substring(0, 7)).ToArray())}" : c.Message)}" + $" (Committer: {c.Committer.Name} [{c.Committer.Email}], Author: {c.Author.Name} [{c.Author.Email}])",
                        User = $"Committer: {c.Committer.Name} ({c.Committer.Email}). Author: {c.Author.Name} ({c.Author.Email})",
                        FileName = c.Id.Sha,
                        Level = AnalogyLogLevel.Warning,
                        Class = AnalogyLogClass.General,
                    };
                    m.AddOrReplaceAdditionalProperty("Category", "TAG");

                    MessageReady(this, new AnalogyLogMessageArgs(m, "", "", Id));
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
                        Date = c.Author.When,
                        Module = RepositorySetting.RepositoryPath,
                        Source = c.Id.Sha,
                        Text = $"Incoming: {c.Committer.Name}:{c.Message}",
                        User = $"Committer: {c.Committer.Name} ({c.Committer.Email}). Author: {c.Author.Name} ({c.Author.Email})",
                        FileName = c.Id.Sha,
                        Level = AnalogyLogLevel.Information,
                        Class = AnalogyLogClass.General,
                    };
                    m.AddOrReplaceAdditionalProperty("Category", c.Tree.FirstOrDefault()?.Name);

                    MessageReady(this, new AnalogyLogMessageArgs(m, "", "", Id));
                }
            }
        }
        public override Task StopReceiving() => Task.CompletedTask;
    }
}