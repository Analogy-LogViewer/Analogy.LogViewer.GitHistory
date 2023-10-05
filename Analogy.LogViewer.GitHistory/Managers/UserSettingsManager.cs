using Analogy.LogViewer.Template.Managers;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Analogy.LogViewer.GitHistory.Managers
{
    public class UserSettingsManager
    {
        private static readonly Lazy<UserSettingsManager> _instance =
            new Lazy<UserSettingsManager>(() => new UserSettingsManager());
        public static UserSettingsManager UserSettings { get; set; } = _instance.Value;
        private string LocalSettingFileName { get; } = "AnalogyGitHistorySettings.json";
        private string RepositoriesSettingFile => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Analogy.LogViewer", LocalSettingFileName);
        public RepositoriesSetting RepositoriesSetting { get; }

        public UserSettingsManager()
        {
            RepositoriesSetting = new RepositoriesSetting();
            if (File.Exists(RepositoriesSettingFile))
            {
                try
                {
                    string data = File.ReadAllText(RepositoriesSettingFile);
                    RepositoriesSetting = JsonConvert.DeserializeObject<RepositoriesSetting>(data);
                }
                catch (Exception ex)
                {
                    LogManager.Instance.LogCritical(ex, $"Unable to read file {RepositoriesSettingFile}: {ex}","");
                }
            }
        }

        public void Save()
        {
            try
            {
                File.WriteAllText(RepositoriesSettingFile, JsonConvert.SerializeObject(RepositoriesSetting));
            }
            catch (Exception ex)
            {
                LogManager.Instance.LogCritical( $"Unable to save file {RepositoriesSettingFile}: {ex}","");

            }


        }
    }
}
