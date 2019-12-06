using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoApp
{
    class Setup
    {
        public bool CheckIfSetupDone(bool SetupDone)
        {
            if (Properties.Settings.Default.SetupDone == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool DoesSettingExist(string settingName)
        {
            return Properties.Settings.Default.Properties.Cast<SettingsProperty>().Any(prop => prop.Name == settingName);
        }

        public void AddApplicationName()
        {
            Console.WriteLine("Please enter the application name.");
            var appName = Console.ReadLine();
            if (DoesSettingExist(appName))
            {
                Console.WriteLine("You already have a configuration for this application.");
                return;
            }
            else
            {
                SaveSettings(appName, appName);
                AddLocalFolderLocation(appName);

                //var addAppName = new SettingsProperty(appName);
                //addAppName.PropertyType = typeof(string);
                //Properties.Settings.Default.Properties.Add(addAppName);
                //Properties.Settings.Default[appName];
                //Properties.Settings.Default["name" + number.ToString()] = value;
                //Properties.Settings.Default.Save();
            }
        }

        public void SaveSettings(string settingName, string settingValue)
        {

            SettingsProperty prop;
            if (Properties.Settings.Default.Properties[settingName] != null)
            {
                prop = Properties.Settings.Default.Properties[settingName];
            }

            else
            {
                prop = new SettingsProperty(settingName);
                prop.PropertyType = typeof(string);
                Properties.Settings.Default.Properties.Add(prop);
                Properties.Settings.Default.Save();
            }

            Properties.Settings.Default.Properties[settingName].DefaultValue = settingValue;

            Properties.Settings.Default.Save();
        }

        public void AddLocalFolderLocation(string appName)
        {
            Console.WriteLine("Please set the local folder path for " + appName);
            var localFolderPathEntry = Console.ReadLine();

            SaveSettings(appName, localFolderPathEntry);
        }
        public void AddRemoteFolderLocation(string appName)
        {
            Console.WriteLine("Please set the remote folder path for " + appName);
            var remoteFolderPathEntry = Console.ReadLine();

            SaveSettings(appName, remoteFolderPathEntry);
        }

        public void CheckIfPathExists()
        {

        }
    }
}
