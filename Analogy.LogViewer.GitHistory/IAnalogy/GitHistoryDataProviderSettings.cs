using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Analogy.Interfaces;
using Analogy.LogViewer.GitHistory.Managers;

namespace Analogy.LogViewer.GitHistory.IAnalogy
{
    public class GitHistoryDataProviderSettings : Template.TemplateUserSettingsFactory
    {

        public override string Title { get; set; } = "Git History settings";
        public override UserControl DataProviderSettings { get; set; }
        public override Image? SmallImage { get; set; }
        public override Image? LargeImage { get; set; }
        public override Guid FactoryId { get; set; } = GitHistoryPrimaryFactory.Id;
        public override Guid Id { get; set; } = new Guid("AEE6AA94-A0B6-4313-8C65-D81943B542DB");

        public override void CreateUserControl(IAnalogyLogger logger)
        {
            DataProviderSettings = new GitRepositoriesSettings();
        }

        public override Task SaveSettingsAsync()
        {
            UserSettingsManager.UserSettings.Save();
            return Task.CompletedTask;
        }
    }
}
