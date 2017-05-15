using System;
using System.IO;
using System.Windows.Forms;

namespace SniperGhostWarriorAutoSaveBackup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveBackupToBtn_Click(object sender, EventArgs e)
        {
            SetPathFromBrowser(saveBackupToTB);
        }

        private void folderToBackupBtn_Click(object sender, EventArgs e)
        {
            SetPathFromBrowser(folderToBackupTB);
        }

        private void SetPathFromBrowser(TextBox tb)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                tb.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Check if "Sniper Ghost Warrior 3" process is running
            if (ProcessManager.FindRunningGame("SGW3")) // SGW3 | Sniper Ghost Warrior 3's friendly name
            {
                ProcessManager.GameProcess.EnableRaisingEvents = true;
                ProcessManager.GameProcess.Exited += GameProcess_Exited;
                // Stop the timer that is responsible for searching for the SGW3 process
                timer1.Stop();

                if (backupEveryCB.Checked)
                {
                    if (!backupTimer.Enabled)
                    {
                        // Start the timer that is responsible for auto backup every x minutes
                        backupTimer.Interval = (int)backupMinutes.Value * 60000;
                        backupTimer.Start();
                    }
                }

                statusLbl.Text = string.Empty;
            }
        }

        private void GameProcess_Exited(object sender, EventArgs e)
        {
            if(saveBackupToTB.Text != string.Empty && folderToBackupTB.Text != string.Empty)
            {
                // Backup savegame
                if (BackupManager.BackupSavegame(folderToBackupTB.Text, saveBackupToTB.Text))
                {
                    UpdateStatutLbl(string.Format("Savegame has been backed up | {0:MMMM d, yyyy. hh:mm tt}", DateTime.Now), true);
                }
                else
                {
                    UpdateStatutLbl("Failed to backup savegame. ERROR CODE: 2", true); // Might happen if not past prologue or no save was found at location
                }
            }
            else
            {
                UpdateStatutLbl("Failed to backup savegame! Please fill in all blank textboxes", true);
            }

            ProcessManager.GameProcess.Exited -= GameProcess_Exited;
        }

        private void UpdateStatutLbl(string text, bool exited)
        {
            if (statusLbl.InvokeRequired)
            {
                if (exited)
                {
                    statusLbl.BeginInvoke((MethodInvoker)delegate { statusLbl.Text = text; timer1.Start(); backupTimer.Stop(); });
                }
                else
                {
                    statusLbl.BeginInvoke((MethodInvoker)delegate { statusLbl.Text = text; });
                }
            }
            else
            {
                statusLbl.Text = text;
            }
        }

        private void backupTimer_Tick(object sender, EventArgs e)
        {
            BackupSaveGame();
        }

        private void backupEveryCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ProcessManager.GameProcess != null)
            {
                if (backupEveryCB.Checked)
                {
                    if (!backupTimer.Enabled)
                    {
                        backupTimer.Interval = (int)backupMinutes.Value * 60000;
                        backupTimer.Start();
                    }
                }
                else
                {
                    if (backupTimer.Enabled)
                    {
                        backupTimer.Stop();
                    }
                }
            }

            groupBox1.Enabled = backupEveryCB.Checked;
        }

        private void backupMinutes_ValueChanged(object sender, EventArgs e)
        {
            backupTimer.Interval = (int)backupMinutes.Value * 60000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load all information
            object[] data = InformationManager.Load();

            if (data == null)
            {
                return;
            }

            string backupLocation = data[0] as string;
            string savegameLocation = data[1] as string;
            bool autoBackup = Convert.ToBoolean(data[2]);

            saveBackupToTB.Text = backupLocation;
            folderToBackupTB.Text = savegameLocation;
            backupEveryCB.Checked = autoBackup;

            // Load savegames list
            savegamesList.Items.AddRange(BackupManager.Backups.ToArray());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            object[] data = new object[3] { saveBackupToTB.Text, folderToBackupTB.Text, backupEveryCB.Checked };
            InformationManager.Save(data);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackupSaveGame();
        }

        private void BackupSaveGame()
        {
            if (BackupManager.BackupSavegame(folderToBackupTB.Text, saveBackupToTB.Text))
            {
                statusLbl.Text = string.Format("Savegame has been backed up | {0:MMMM d, yyyy. hh:mm tt}", DateTime.Now);
            }
            else
            {
                statusLbl.Text = "Failed to backup savegame. ERROR CODE: 2"; // Might happen if not past prologue or no save was found at location
            }
        }

        private void loadSavegameBtn_Click(object sender, EventArgs e)
        {
            if (savegamesList.SelectedIndex > -1)
            {
                
            }
        }
    }
}
