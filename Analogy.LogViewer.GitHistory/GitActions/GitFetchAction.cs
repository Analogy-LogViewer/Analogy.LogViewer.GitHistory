using Analogy.Interfaces;
using Analogy.Interfaces.DataTypes;
using Analogy.Interfaces.WinForms;
using Analogy.Interfaces.WinForms.DataTypes;
using Analogy.LogViewer.GitHistory.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analogy.LogViewer.GitHistory.GitActions
{
    public class GitFetchAction : IAnalogyCustomActionWinForms
    {
        public Action Action { get; } = () =>
        {
            var f = new GitOperationsForm();
            f.ShowDialog(Application.OpenForms[0]);
        };

        public Guid Id { get; set; } = new Guid("FD8E1ED1-20DA-4783-87EC-9FAC66422CC1");
        public Image? SmallImage { get; set; } = Resources.Git_icon_16x16;
        public Image? LargeImage { get; set; } = Resources.Git_icon_32x32;

        public string Title { get; set; } = "Git Fetch";
        public AnalogyCustomActionType Type { get; } = AnalogyCustomActionType.BelongsToProvider;
        public AnalogyToolTip? ToolTip { get; set; }
        public Image? GetCustomActionSmallImage(Guid componentId) => SmallImage;
        public Image? GetCustomActionLargeImage(Guid componentId) => LargeImage;
        public Image? GetCustomActionToolTipSmallImage(Guid componentId) => SmallImage;
        public Image? GetCustomActionToolTipLargeImage(Guid componentId) => LargeImage;
    }
}