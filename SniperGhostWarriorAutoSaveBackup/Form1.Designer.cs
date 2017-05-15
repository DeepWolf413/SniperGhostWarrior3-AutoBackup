namespace SniperGhostWarriorAutoSaveBackup
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.saveBackupToTB = new System.Windows.Forms.TextBox();
            this.saveBackupToBtn = new System.Windows.Forms.Button();
            this.folderToBackupBtn = new System.Windows.Forms.Button();
            this.folderToBackupTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backupEveryCB = new System.Windows.Forms.CheckBox();
            this.backupMinutes = new System.Windows.Forms.NumericUpDown();
            this.backupTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.savegamesList = new System.Windows.Forms.ListBox();
            this.loadSavegameBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backupMinutes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup location:";
            // 
            // saveBackupToTB
            // 
            this.saveBackupToTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBackupToTB.Location = new System.Drawing.Point(106, 10);
            this.saveBackupToTB.Name = "saveBackupToTB";
            this.saveBackupToTB.Size = new System.Drawing.Size(299, 20);
            this.saveBackupToTB.TabIndex = 1;
            // 
            // saveBackupToBtn
            // 
            this.saveBackupToBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBackupToBtn.Location = new System.Drawing.Point(411, 8);
            this.saveBackupToBtn.Name = "saveBackupToBtn";
            this.saveBackupToBtn.Size = new System.Drawing.Size(39, 23);
            this.saveBackupToBtn.TabIndex = 2;
            this.saveBackupToBtn.Text = "...";
            this.saveBackupToBtn.UseVisualStyleBackColor = true;
            this.saveBackupToBtn.Click += new System.EventHandler(this.saveBackupToBtn_Click);
            // 
            // folderToBackupBtn
            // 
            this.folderToBackupBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.folderToBackupBtn.Location = new System.Drawing.Point(411, 34);
            this.folderToBackupBtn.Name = "folderToBackupBtn";
            this.folderToBackupBtn.Size = new System.Drawing.Size(39, 23);
            this.folderToBackupBtn.TabIndex = 5;
            this.folderToBackupBtn.Text = "...";
            this.folderToBackupBtn.UseVisualStyleBackColor = true;
            this.folderToBackupBtn.Click += new System.EventHandler(this.folderToBackupBtn_Click);
            // 
            // folderToBackupTB
            // 
            this.folderToBackupTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderToBackupTB.Location = new System.Drawing.Point(106, 36);
            this.folderToBackupTB.Name = "folderToBackupTB";
            this.folderToBackupTB.Size = new System.Drawing.Size(299, 20);
            this.folderToBackupTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Savegame folder:";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(13, 61);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(58, 13);
            this.statusLbl.TabIndex = 6;
            this.statusLbl.Text = "StatusText";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backupEveryCB
            // 
            this.backupEveryCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backupEveryCB.AutoSize = true;
            this.backupEveryCB.Location = new System.Drawing.Point(16, 191);
            this.backupEveryCB.Name = "backupEveryCB";
            this.backupEveryCB.Size = new System.Drawing.Size(198, 17);
            this.backupEveryCB.TabIndex = 8;
            this.backupEveryCB.Text = "Enable auto backup every x minutes";
            this.backupEveryCB.UseVisualStyleBackColor = true;
            this.backupEveryCB.CheckedChanged += new System.EventHandler(this.backupEveryCB_CheckedChanged);
            // 
            // backupMinutes
            // 
            this.backupMinutes.Location = new System.Drawing.Point(46, 20);
            this.backupMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.backupMinutes.Name = "backupMinutes";
            this.backupMinutes.ReadOnly = true;
            this.backupMinutes.Size = new System.Drawing.Size(49, 23);
            this.backupMinutes.TabIndex = 9;
            this.backupMinutes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.backupMinutes.ValueChanged += new System.EventHandler(this.backupMinutes_ValueChanged);
            // 
            // backupTimer
            // 
            this.backupTimer.Interval = 2000;
            this.backupTimer.Tick += new System.EventHandler(this.backupTimer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Every";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.backupMinutes);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 44);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto backup";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "minutes";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(354, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Force a backup";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.loadSavegameBtn);
            this.groupBox2.Controls.Add(this.savegamesList);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(251, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 146);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Savegame backups";
            // 
            // savegamesList
            // 
            this.savegamesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savegamesList.FormattingEnabled = true;
            this.savegamesList.ItemHeight = 16;
            this.savegamesList.Location = new System.Drawing.Point(6, 22);
            this.savegamesList.Name = "savegamesList";
            this.savegamesList.Size = new System.Drawing.Size(187, 84);
            this.savegamesList.TabIndex = 0;
            // 
            // loadSavegameBtn
            // 
            this.loadSavegameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadSavegameBtn.Location = new System.Drawing.Point(6, 112);
            this.loadSavegameBtn.Name = "loadSavegameBtn";
            this.loadSavegameBtn.Size = new System.Drawing.Size(187, 27);
            this.loadSavegameBtn.TabIndex = 1;
            this.loadSavegameBtn.Text = "Load savegame";
            this.loadSavegameBtn.UseVisualStyleBackColor = true;
            this.loadSavegameBtn.Click += new System.EventHandler(this.loadSavegameBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 270);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backupEveryCB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.folderToBackupBtn);
            this.Controls.Add(this.folderToBackupTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveBackupToBtn);
            this.Controls.Add(this.saveBackupToTB);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(371, 199);
            this.Name = "Form1";
            this.Text = "Sniper Ghost Warrior 3 Auto Backup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backupMinutes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox saveBackupToTB;
        private System.Windows.Forms.Button saveBackupToBtn;
        private System.Windows.Forms.Button folderToBackupBtn;
        private System.Windows.Forms.TextBox folderToBackupTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox backupEveryCB;
        private System.Windows.Forms.NumericUpDown backupMinutes;
        private System.Windows.Forms.Timer backupTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button loadSavegameBtn;
        private System.Windows.Forms.ListBox savegamesList;
    }
}

