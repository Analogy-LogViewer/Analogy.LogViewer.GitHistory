using Analogy.Interfaces;
using Analogy.Interfaces.Factories;
using Analogy.Interfaces.WinForms;
using Analogy.LogViewer.GitHistory.GitActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogy.LogViewer.GitHistory.IAnalogy
{
    public class GitHistoryCustomActionsFactoryWinForms
    {
        public Guid FactoryId { get; } = GitHistoryPrimaryFactory.Id;
        public string Title { get; } = "Git Operations";
        public IEnumerable<IAnalogyCustomActionWinForms> Actions { get; } = new List<IAnalogyCustomActionWinForms> { new GitFetchAction() };
    }
}