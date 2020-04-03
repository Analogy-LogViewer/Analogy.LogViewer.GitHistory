using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Analogy.Interfaces;

namespace Analogy.LogViewer.GitHistory.GitActions
{
    public class GitPullAction: IAnalogyCustomAction
    {
        public Action Action { get; }= ()=>
        {
            var f = new GitOperationsForm();
            f.ShowDialog(Application.OpenForms[0]);
        };
        public Guid ID { get; } = new Guid("FD8E1ED1-20DA-4783-87EC-9FAC66422CC1");
        public string Title { get; } = "Git Pull";


    }
}
