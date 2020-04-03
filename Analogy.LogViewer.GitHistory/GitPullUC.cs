using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Analogy.LogViewer.GitHistory.Managers;
using LibGit2Sharp;

namespace Analogy.LogViewer.GitHistory
{
    public partial class GitPullUC : UserControl
    {
        private RepositorySetting RepositorySetting { get; set; }
        public GitPullUC()
        {
            InitializeComponent();
        }

        public GitPullUC(RepositorySetting repositorySetting)
        {
            RepositorySetting = repositorySetting;
        }

        private void BtnOperation_Click(object sender, EventArgs e)
        {
            if (RepositorySetting == null) return;

            string logMessage = "";
            using (var repo = new Repository(RepositorySetting.RepositoryPath))
            {
                var remote = repo.Network.Remotes["origin"];
                var refSpecs = remote.FetchRefSpecs.Select(x => x.Specification);
                Commands.Fetch(repo, remote.Name, refSpecs, null, logMessage);
            

                var trackingBranch = repo.Head.TrackedBranch;
                var log = repo.Commits.QueryBy(new CommitFilter
                    {IncludeReachableFrom = trackingBranch.Tip.Id, ExcludeReachableFrom = repo.Head.Tip.Id});

                var count = log.Count(); //Counts the number of log entries

                //iterate the commits that represent the difference between your last 
                //push to the remote branch and latest commits
                txtbResult.Text = string.Join(Environment.NewLine,
                    log.Select(c => $"{c.Committer.Name}:{c.Message}").ToArray());
            }
        }

        private void GitPullUC_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            RefreshList();
        }
        private void RefreshList()
        {
            lstRepositores.DataSource = null;
            lstRepositores.DataSource = UserSettingsManager.UserSettings.RepositoriesSetting.Repositories;
        }

        private void lstRepositores_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstRepositores.SelectedItem is RepositorySetting rs)
            {
                RepositorySetting = rs;
            }
        }
    }
}
