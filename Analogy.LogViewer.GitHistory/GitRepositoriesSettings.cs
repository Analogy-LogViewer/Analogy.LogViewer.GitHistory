using Analogy.LogViewer.GitHistory.Managers;
using System;
using System.IO;
using System.Windows.Forms;

namespace Analogy.LogViewer.GitHistory
{
    public partial class GitRepositoriesSettings : UserControl
    {
        public GitRepositoriesSettings()
        {
            InitializeComponent();
        }

        private void GitRepositoriesSettings_Load(object sender, EventArgs e)
        {
            // lstRepositores.DataSource = UserSettingsManager.UserSettings.RepositoriesSetting;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRepository.Text) || Directory.Exists(txtRepository.Text))
            {
                FetchType f = rbCount.Checked ? FetchType.Count : FetchType.DateTime;
                RepositorySetting rs = new RepositorySetting(txtRepository.Text, (int)nudCommits.Value,
                    dateTimePicker1.Value, f);
                UserSettingsManager.UserSettings.RepositoriesSetting.AddRepository(rs);
            }
        }
    }
}
