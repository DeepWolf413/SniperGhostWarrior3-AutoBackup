using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SniperGhostWarriorAutoSaveBackup
{
    public static class BackupManager
    {
        private static List<DirectoryInfo> backups = new List<DirectoryInfo>();
        public static List<DirectoryInfo> Backups
        {
            get
            {
                if (backups.Count == 0)
                {
                    string[] dirs = Directory.GetDirectories(InformationManager.GetValue<string>("Backup location"));
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        backups.Add(new DirectoryInfo(dirs[i]));
                    }
                }

                return backups;
            }
        }

        public static bool BackupSavegame(string sourceDest, string destination)
        {
            string dest = Path.Combine(destination, GetCurrentTime());

            if (DirectoryUtilities.CopyDirectory(sourceDest, dest, true))
            {
                backups.Add(new DirectoryInfo(dest));
                return true;
            }

            return false;
        }

        public static void LoadBackup()
        {
            
        }

        private static string GetCurrentTime()
        {
            return string.Format("{0:MMMM d, yyyy. hh.mm tt}", DateTime.Now);
        }
    }
}
