using Analogy.Interfaces;
using Analogy.Interfaces.Factories;
using System;
using System.Collections.Generic;

namespace Analogy.LogViewer.GitHistory.IAnalogy
{
    public class GitHistoryDataProviderFactory : IAnalogyDataProvidersFactory
    {
        public Guid FactoryId { get; } = GitHistoryFactory.Id;
        public string Title => "Repositories History";
        public IEnumerable<IAnalogyDataProvider> DataProviders { get; } = new List<IAnalogyDataProvider>
        {
            new GitRepositoryLoader()
        };

    }
}
