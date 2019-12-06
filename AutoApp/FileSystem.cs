using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoApp
{
    class FileSystem
    {
        //public bool CheckIfPathExists(string folderPath)
        //{
        //    if (Directory.Exists(folderPath))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //Simply bool to check if the directory exists. We use this multiple times when adding or updating apps.
        public bool CheckIfPathExists(string checkPath)
        {
            var checkDirectory = new DirectoryInfo(checkPath);
            var doesItExist = true;
            if (checkDirectory.Exists == false)
            {
                Console.WriteLine("The path does not exist, or is not accessible. Please enter it again.");
                doesItExist = false;
            }
            return doesItExist;
        }

        //This get the app name given and pulls all of the setting file information on what paths have been set.
        //I have to fix this to pull the settings from the app.config.
        public void CopyFolderLocally(string app)
        {
            //Initializers
            var fileName = "";
            var appLocalPath = app + "LocalPath";
            var appRemotePath = app + "RemotePath";
            var localFile = "";
            //So we don't blow up when trying to copy the folder.
            if (CheckIfPathExists(appLocalPath) || CheckIfPathExists(appRemotePath) == false)
            {
                Console.WriteLine("The path existed when you configured the app " + app + ", but it is no longer accessible.");
                Console.WriteLine("Please check the path is accessible or not.");
            }

            //Can we rewrite this to use DirectoryInfo?
            var copyRemoteFiles = Directory.GetFiles(appRemotePath);
            //var copyAllTheThings = new DirectoryInfo(appLocalPath);
            //var fileList = copyAllTheThings.GetFiles();

            foreach (var file in copyRemoteFiles)
            {
                //We create a temp folder to copy the files locally.
                var tempLocalFolder = appLocalPath + "temp";
                fileName = Path.GetFileName(file);
                localFile = Path.Combine(tempLocalFolder, fileName);
                File.Copy(fileName, tempLocalFolder);
            }

            DeleteOldVersion(appLocalPath);
            ReplaceOldVersion(appLocalPath);
        }

        //Delete the old "version" of the folder locally.
        public void DeleteOldVersion(string appLocalPath)
        {
            Directory.Delete(appLocalPath);
        }
        //Simple rename of the temp folder.
        public void ReplaceOldVersion(string appLocalPath)
        {
            Directory.Move(appLocalPath + "temp", appLocalPath);
        }
    }
}
