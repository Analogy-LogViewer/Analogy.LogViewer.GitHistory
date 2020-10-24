using Analogy.Interfaces;
using Analogy.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Drawing;
using Analogy.LogViewer.GitHistory.Properties;

namespace Analogy.LogViewer.GitHistory.IAnalogy
{
    public class GitHistoryFactory : IAnalogyFactory
    {
        internal static Guid Id = new Guid("B842CC0F-AD83-48FB-8394-3189F9A75024");
    
        public Guid FactoryId { get; set; } = Id;

        public string Title { get; set; } = "Git History";
        public Image SmallImage { get; set; } = Resources.Git_icon_16x16;
        public Image LargeImage { get; set; } = Resources.Git_icon_32x32;
        public IEnumerable<IAnalogyChangeLog> ChangeLog { get; set; } = new List<AnalogyChangeLog>
        {
            new AnalogyChangeLog("Initial version",AnalogChangeLogType.None, "Lior Banai",new DateTime(2020, 04, 02))
        };
        public IEnumerable<string> Contributors { get; set; } = new List<string> { "Lior Banai" };
        public string About { get; set; } = "Analogy Git History";

        public void RegisterNotificationCallback(INotificationReporter notificationReporter)
        {
           
        }
    }
}
