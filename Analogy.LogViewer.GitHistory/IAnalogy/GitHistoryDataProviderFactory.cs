using Analogy.Interfaces;
using Analogy.Interfaces.Factories;
using Analogy.LogViewer.GitHistory.Managers;
using System;
using System.Collections.Generic;
using Analogy.LogViewer.GitHistory.Data_Types;

namespace Analogy.LogViewer.GitHistory.IAnalogy
{
    public class GitHistoryDataProviderFactory : IAnalogyDataProvidersFactory
    {
        public Guid FactoryId { get; set; } = GitHistoryFactory.Id;
        public string Title { get; set; } = "Repositories History";

        public IEnumerable<IAnalogyDataProvider> DataProviders
        {
            get
            {
                foreach (RepositorySetting rs in UserSettingsManager.UserSettings.RepositoriesSetting.Repositories)
                {
                    yield return new GitRepositoryLoader(rs, GitOperationType.History);
                }
            }

        }
    }
    public class GitFetchDataProviderFactory
    {
        public Guid FactoryId { get; } = GitHistoryFactory.Id;
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
