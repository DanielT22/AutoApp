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
        public bool CheckIfPathExists(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
