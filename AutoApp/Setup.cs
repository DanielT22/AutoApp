using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoApp
{
    class Setup
    {
        //A simpyl check to see if the setup is done.
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

        //A way to check if a specific setting has been set or not for validation. I really need to understand what this code is doing.
        public bool DoesSettingExist(string settingName)
        {
            return Properties.Settings.Default.Properties.Cast<SettingsProperty>().Any(prop => prop.Name == settingName);
        }

        //This method deals with adding a new application to the settings file. This also chains in two other methods to
        //Add the remote and local folder locations associated with the application name from the settings file.
        public void AddApplicationName()
        {
            //I will need to see if I can just feed it everything from the Main() method instead of asking like this.
            //I like both ways as an option.
            Console.WriteLine("Please enter the application name.");
            var appName = Console.ReadLine();
            if (DoesSettingExist(appName))
            {
                Console.WriteLine("You already have a configuration for this application.");
                return;
            }
            else
            {
                //Save the settings we made.. create settings for local and remote folders.
                SaveSettings(appName, appName);
                AddLocalFolderLocation(appName);
                AddRemoteFolderLocation(appName);

                //var addAppName = new SettingsProperty(appName);
                //addAppName.PropertyType = typeof(string);
                //Properties.Settings.Default.Properties.Add(addAppName);
                //Properties.Settings.Default[appName];
                //Properties.Settings.Default["name" + number.ToString()] = value;
                //Properties.Settings.Default.Save();
            }
            return;
        }

        public void SaveSettings(string settingName, string settingValue)
        {
            //This method will deal with two strings given and set the settings value for them. Useful for multiple methods.
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

            //We have to save the settings, otherwise we'll lose the config when we close the app.
            Properties.Settings.Default.Save();
        }

        public void AddLocalFolderLocation(string appName)
        {
            Console.WriteLine("Please set the local folder path for " + appName);

            var localFolderPathEntry = Console.ReadLine();
            var check = new FileSystem();
            while (check.CheckIfPathExists(localFolderPathEntry) == false)
            {
                localFolderPathEntry = Console.ReadLine();
            }

            SaveSettings(appName + "LocalPath", localFolderPathEntry);
        }
        public void AddRemoteFolderLocation(string appName)
        {
            Console.WriteLine("Please set the remote folder path for " + appName);
            var remoteFolderPathEntry = Console.ReadLine();
            var check = new FileSystem();
            while (check.CheckIfPathExists(remoteFolderPathEntry) == false)
            {
                remoteFolderPathEntry = Console.ReadLine();
            }

            SaveSettings(appName + "RemotePath", remoteFolderPathEntry);
        }
    }
}
