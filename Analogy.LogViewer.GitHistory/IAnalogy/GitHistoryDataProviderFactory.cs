using Analogy.Interfaces;
using Analogy.LogViewer.GitHistory.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using Analogy.LogViewer.GitHistory.DataTypes;

namespace Analogy.LogViewer.GitHistory.IAnalogy
{
    public class GitHistoryDataProviderFactory : Template.DataProvidersFactory
    {
        public override Guid FactoryId { get; set; } = GitHistoryPrimaryFactory.Id;
        public override string Title { get; set; } = "Repositories History";

        public override IEnumerable<IAnalogyDataProvider> DataProviders
        {
            get => _dataProviders;
            set => _dataProviders = value.ToList();
        }


        private List<IAnalogyDataProvider> _dataProviders;

        public GitHistoryDataProviderFactory()
        {
            _dataProviders = UserSettingsManager.UserSettings.RepositoriesSetting.Repositories
                .Select(rs => new GitRepositoryLoader(rs, GitOperationType.History)).Cast<IAnalogyDataProvider>()
                .ToList();
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
