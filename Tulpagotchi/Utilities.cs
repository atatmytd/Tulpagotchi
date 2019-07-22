using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Configuration;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Media;

namespace Tulpagotchi
{
    public class Utilities
    {
        public static string GetConfigValue(string Key)
        {
            string value = "";
            var appSettings = ConfigurationManager.AppSettings;

            foreach (var key in appSettings.AllKeys)
                if (key == Key)
                    value = appSettings[key];

            return value;
        }
        public static void SetConfigValue(string Key, string Value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = config.AppSettings.Settings;

            if (settings[Key] == null)
                settings.Add(Key, Value);
            else settings[Key].Value = Value;

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }
        public static bool ValidNumberField(string enteredText)
        {
            if (decimal.TryParse(enteredText, out decimal d))
                return true;
            else return false;
        }
        public static string GetVersionNumber()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fileVersionInfo.ProductVersion;

            return version;
        }
        public static string ChooseFileLocation(string fileExt, string fileExtName, string defaultFileName)
        {
            string filePath = "";

            //open up a file dialog
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = string.Format("{1} (*.{0})|*.{0}", fileExt, fileExtName);
            save.FileName = string.Format("{0}", defaultFileName);
            if (save.ShowDialog() == true)
                filePath = save.FileName;

            return filePath;
        }
        public static string GetFileLocation(string fileExt, string fileExtName )
        {
            string filePath = "";

            //open up a file dialog
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = string.Format("{1} (*.{0})|*.{0}", fileExt, fileExtName);
            if (open.ShowDialog() == true)
                filePath = open.FileName;

            return filePath;
        }
    }
}
