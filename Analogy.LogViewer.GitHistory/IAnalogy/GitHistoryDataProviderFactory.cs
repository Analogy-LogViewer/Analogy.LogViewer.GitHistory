using Analogy.Interfaces;
using Analogy.Interfaces.WinForms;
using Analogy.LogViewer.GitHistory.DataTypes;
using Analogy.LogViewer.GitHistory.Managers;
using Analogy.LogViewer.Template.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Analogy.LogViewer.GitHistory.IAnalogy
{
    public class GitHistoryDataProviderFactory : DataProvidersFactoryWinForms
    {
        public override Guid FactoryId { get; set; } = GitHistoryPrimaryFactory.Id;
        public override string Title { get; set; } = "Repositories History";

        public GitHistoryDataProviderFactory()
        {
            DataProviders = UserSettingsManager.UserSettings.RepositoriesSetting.Repositories
                .Select(rs => new GitRepositoryLoader(rs, GitOperationType.History)).ToList();
        }
    }

    public class GitFetchDataProviderFactory
    {
        public Guid FactoryId { get; } = GitHistoryPrimaryFactory.Id;
        public string Title => "Repositories Fetches";

        public IEnumerable<IAnalogyDataProvider> DataProviders
        {
            get
            {
                foreach (RepositorySetting rs in UserSettingsManager.UserSettings.RepositoriesSetting.Repositories)
                {
                    yield return new GitRepositoryLoader(rs, GitOperationType.Fetch);
                }
            }
        }
    }
}