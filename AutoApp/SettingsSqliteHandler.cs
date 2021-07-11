using SQLite;
using System;
using System.Collections.Generic;

namespace AutoApp
{
    public class SettingsSqliteHandler
    {
        public static string databaseName = "AutoAppSettings.db";

        public static string folderPath = Environment.CurrentDirectory;
        public static string databasePath = System.IO.Path.Combine(folderPath, databaseName);

        public static List<SettingsModel> ConnectionSettingsList { get; set; }

        public void ReadDatabase()
        {
            List<SettingsModel> contacts;
            using (SQLiteConnection connection = new SQLiteConnection(databasePath))
            {
                connection.CreateTable<SettingsModel>();
                contacts = connection.Table<SettingsModel>().ToList();
            }

            ConnectionSettingsList = contacts;
        }

        public void AddSetting(SettingsModel setting)
        {
            using (SQLiteConnection connection = new SQLiteConnection(databasePath))
            {
                connection.CreateTable<SettingsModel>();
                connection.Insert(setting);
            }
        }

        public void EditSetting(SettingsModel setting)
        {
            using (SQLiteConnection connection = new SQLiteConnection(databasePath))
            {
                connection.CreateTable<SettingsModel>();
                connection.Update(setting);
            }
        }

        public void DeleteSetting(SettingsModel setting)
        {
            using (SQLiteConnection connection = new SQLiteConnection(databasePath))
            {
                connection.CreateTable<SettingsModel>();
                connection.Delete(setting);
            }
        }
    }
}
