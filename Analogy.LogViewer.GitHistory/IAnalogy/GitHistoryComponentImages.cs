using Analogy.LogViewer.GitHistory.Properties;
using System;
using System.Drawing;
using Analogy.Interfaces;

namespace Analogy.LogViewer.GitHistory.IAnalogy
{
    public class GitHistoryComponentImages : IAnalogyComponentImages
    {
        public Image GetLargeImage(Guid analogyComponentId)
        {
            if (analogyComponentId == GitHistoryFactory.Id)
                return Resources.Git_icon_32x32;
            return null;
        }

        public Image GetSmallImage(Guid analogyComponentId)
        {
            if (analogyComponentId == GitHistoryFactory.Id)
                return Resources.Git_icon_16x16;
            return null;
        }

        public Image GetOnlineConnectedLargeImage(Guid analogyComponentId) => null;

        public Image GetOnlineConnectedSmallImage(Guid analogyComponentId) => null;

        public Image GetOnlineDisconnectedLargeImage(Guid analogyComponentId) => null;

        public Image GetOnlineDisconnectedSmallImage(Guid analogyComponentId) => null;
    }
}
