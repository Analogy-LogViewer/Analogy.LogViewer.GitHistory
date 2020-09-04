using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Analogy.Interfaces;
using Analogy.LogViewer.GitHistory.Managers;

namespace Analogy.LogViewer.GitHistory.IAnalogy
{
    public class GitHistoryDataProviderSettings : IAnalogyDataProviderSettings
    {

        public string Title { get; set; } = "Git History settings";
        public UserControl DataProviderSettings { get; } = new GitRepositoriesSettings();
        public Image SmallImage { get; set; }
        public Image LargeImage { get; set; }
        public Guid FactoryId { get; set; } = GitHistoryFactory.Id;
        public Guid Id { get; set; } = new Guid("AEE6AA94-A0B6-4313-8C65-D81943B542DB");

        public Task SaveSettingsAsync()
        {
            UserSettingsManager.UserSettings.Save();
            return Task.CompletedTask;
        }
    }
}
