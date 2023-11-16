using Analogy.Interfaces;
using Analogy.Interfaces.Factories;
using Analogy.LogViewer.GitHistory.GitActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogy.LogViewer.GitHistory.IAnalogy
{
    public class GitHistoryCustomActionsFactory
    {
        public Guid FactoryId { get; } = GitHistoryPrimaryFactory.Id;
        public string Title { get; } = "Git Operations";
        public IEnumerable<IAnalogyCustomAction> Actions { get; } = new List<IAnalogyCustomAction> { new GitFetchAction() };
    }
}