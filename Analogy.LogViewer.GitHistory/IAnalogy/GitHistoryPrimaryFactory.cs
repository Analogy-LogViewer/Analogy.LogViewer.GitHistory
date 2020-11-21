using Analogy.Interfaces;
using Analogy.LogViewer.GitHistory.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Analogy.LogViewer.GitHistory.IAnalogy
{
    public class GitHistoryPrimaryFactory : Template.PrimaryFactory
    {
        internal static Guid Id = new Guid("B842CC0F-AD83-48FB-8394-3189F9A75024");
        public override Guid FactoryId { get; set; } = Id;
        public override string Title { get; set; } = "Git History";
        public override Image? SmallImage { get; set; } = Resources.Git_icon_16x16;
        public override Image? LargeImage { get; set; } = Resources.Git_icon_32x32;
        public override IEnumerable<IAnalogyChangeLog> ChangeLog { get; set; } = new List<AnalogyChangeLog>
        {
            new AnalogyChangeLog("Initial version",AnalogChangeLogType.None, "Lior Banai",new DateTime(2020, 04, 02))
        };
        public override IEnumerable<string> Contributors { get; set; } = new List<string> { "Lior Banai" };
        public override string About { get; set; } = "Analogy Git History";

    }
}
