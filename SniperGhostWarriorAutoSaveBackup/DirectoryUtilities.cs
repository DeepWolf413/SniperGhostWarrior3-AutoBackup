using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniperGhostWarriorAutoSaveBackup
{
    public static class DirectoryUtilities
    {
        public static bool CopyDirectory(string sourceDir, string destDir, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo directory = new DirectoryInfo(sourceDir);
            if (!directory.Exists)
            {
                return false;
            }

            DirectoryInfo[] directories = directory.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDir))
            {
                Directory.CreateDirectory(destDir);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = directory.GetFiles();
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = files[i];

                string temppath = Path.Combine(destDir, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in directories)
                {
                    string temppath = Path.Combine(destDir, subdir.Name);
                    CopyDirectory(subdir.FullName, temppath, copySubDirs);
                }
            }

            return true;
        }
    }
}
