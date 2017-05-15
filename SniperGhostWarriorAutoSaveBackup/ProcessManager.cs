using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniperGhostWarriorAutoSaveBackup
{
    public static class ProcessManager
    {
        public static Process GameProcess { get; private set; }

        public static bool FindRunningGame(string friendlyProcessName)
        {
            Process[] processes = Process.GetProcessesByName(friendlyProcessName);
            if (processes.Length > 0)
            {
                GameProcess = processes[0];
                return true;
            }

            return false;
        }
    }
}
