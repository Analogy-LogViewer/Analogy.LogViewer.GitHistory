using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Analogy.DataProviders.Extensions;
using Analogy.LogViewer.GitHistory.Managers;

namespace Analogy.LogViewer.GitHistory.IAnalogy
{
   public class GitHistoryDataProviderSettings :IAnalogyDataProviderSettings
   {

       public string Title { get; } = "Git History settings";
        public UserControl DataProviderSettings { get; }=new GitRepositoriesSettings();
        public Image SmallImage { get; }
        public Image LargeImage { get; }
        public Guid FactoryId { get; } = GitHistoryFactory.Id;

        public Task SaveSettingsAsync()
        {
            UserSettingsManager.UserSettings.Save();
            return Task.CompletedTask;
        }
    }
}
