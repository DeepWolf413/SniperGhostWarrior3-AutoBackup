using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;

namespace SniperGhostWarriorAutoSaveBackup
{
    public static class InformationManager
    {
        /// <summary>
        /// 1 = Backup location : string
        /// 2 = Savegame location : string
        /// 3 = Auto backup : bool
        /// </summary>
        /// <param name="data"></param>
        public static void Save(object[] data)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\SGW Auto Backup");
            key.SetValue("Backup location", data[0] as string); // Saves backup path to registry
            key.SetValue("Savegame location", data[1] as string); // Saves savegame path to registry
            key.SetValue("Auto backup", data[2] as bool?); // Saves auto backup path to registry
            key.Close();
        }

        /// <summary>
        /// Returns
        /// 1 = Backup location : string
        /// 2 = Savegame location : string
        /// 3 = Auto backup : bool?
        /// </summary>
        /// <returns></returns>
        public static object[] Load()
        {
            object[] data = new object[3];

            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\SGW Auto Backup");
            if (key == null)
            {
                return null;
            }

            data[0] = key.GetValue("Backup location") as string;
            data[1] = key.GetValue("Savegame location") as string;
            data[2] = Convert.ToBoolean(key.GetValue("Auto backup"));
            key.Close();

            return data;
        }

        public static T GetValue<T>(string keyName)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\SGW Auto Backup");
            if (key == null)
            {
                return default(T);
            }

            T value = (T)key.GetValue(keyName);
            key.Close();
            return value;
        }
    }
}
