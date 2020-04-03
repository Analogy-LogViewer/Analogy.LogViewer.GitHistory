using Analogy.Interfaces;
using Analogy.Interfaces.Factories;
using Analogy.LogViewer.GitHistory.Managers;
using System;
using System.Collections.Generic;

namespace Analogy.LogViewer.GitHistory.IAnalogy
{
    public class GitHistoryDataProviderFactory : IAnalogyDataProvidersFactory
    {
        public Guid FactoryId { get; } = GitHistoryFactory.Id;
        public string Title => "Repositories History";

        public IEnumerable<IAnalogyDataProvider> DataProviders
        {
            get
            {
                foreach (RepositorySetting rs in UserSettingsManager.UserSettings.RepositoriesSetting.Repositories)
                {
                    yield return new GitRepositoryLoader(rs);
                }
            }

        }
    }
}
