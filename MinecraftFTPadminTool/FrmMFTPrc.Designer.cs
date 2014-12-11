namespace MinecraftFTPadminTool
{
    partial class MFTPrc
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MFTPrc));
            this.tbsend = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.tbSrvPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbrconPass = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFTPuser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFTPIP = new System.Windows.Forms.TextBox();
            this.tbFTPpass = new System.Windows.Forms.TextBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.rtbShow = new System.Windows.Forms.RichTextBox();
            this.trefreshlog = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btOptions = new System.Windows.Forms.Button();
            this.btRestore = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btLoad = new System.Windows.Forms.Button();
            this.lbConfigs = new System.Windows.Forms.ListBox();
            this.rtConfigs = new System.Windows.Forms.RichTextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.lbForm = new System.Windows.Forms.Label();
            this.btSwitch = new System.Windows.Forms.Button();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.gbGameConf = new System.Windows.Forms.GroupBox();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbSaveData = new System.Windows.Forms.CheckBox();
            this.cbBackup = new System.Windows.Forms.CheckBox();
            this.tbBackupDir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbConfigDir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFTPDir = new System.Windows.Forms.TextBox();
            this.lbFTPDirectory = new System.Windows.Forms.Label();
            this.gbFormOption = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbRefresh = new System.Windows.Forms.Label();
            this.sbRefreshrate = new System.Windows.Forms.HScrollBar();
            this.sbOpacity = new System.Windows.Forms.HScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlServerConsole = new System.Windows.Forms.Panel();
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.gbGameConf.SuspendLayout();
            this.gbFormOption.SuspendLayout();
            this.pnlServerConsole.SuspendLayout();
            this.pnlConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbsend
            // 
            this.tbsend.Location = new System.Drawing.Point(3, 274);
            this.tbsend.Name = "tbsend";
            this.tbsend.Size = new System.Drawing.Size(492, 20);
            this.tbsend.TabIndex = 1;
            this.tbsend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbsend_KeyDown);
            // 
            // btSend
            // 
            this.btSend.Enabled = false;
            this.btSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSend.Location = new System.Drawing.Point(501, 272);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(82, 23);
            this.btSend.TabIndex = 2;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // tbSrvPort
            // 
            this.tbSrvPort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbSrvPort.Location = new System.Drawing.Point(6, 35);
            this.tbSrvPort.Name = "tbSrvPort";
            this.tbSrvPort.Size = new System.Drawing.Size(133, 20);
            this.tbSrvPort.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ServerIP:Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Passwort";
            // 
            // tbrconPass
            // 
            this.tbrconPass.Location = new System.Drawing.Point(6, 74);
            this.tbrconPass.Name = "tbrconPass";
            this.tbrconPass.Size = new System.Drawing.Size(133, 20);
            this.tbrconPass.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbrconPass);
            this.groupBox1.Controls.Add(this.tbSrvPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(589, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 103);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RCON";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbFTPuser);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbFTPIP);
            this.groupBox2.Controls.Add(this.tbFTPpass);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(589, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 154);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FTP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Benutzername";
            // 
            // tbFTPuser
            // 
            this.tbFTPuser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbFTPuser.Location = new System.Drawing.Point(6, 77);
            this.tbFTPuser.Name = "tbFTPuser";
            this.tbFTPuser.Size = new System.Drawing.Size(133, 20);
            this.tbFTPuser.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "FTPserverIP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Passwort";
            // 
            // tbFTPIP
            // 
            this.tbFTPIP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbFTPIP.Location = new System.Drawing.Point(6, 32);
            this.tbFTPIP.Name = "tbFTPIP";
            this.tbFTPIP.Size = new System.Drawing.Size(133, 20);
            this.tbFTPIP.TabIndex = 7;
            // 
            // tbFTPpass
            // 
            this.tbFTPpass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbFTPpass.Location = new System.Drawing.Point(6, 123);
            this.tbFTPpass.Name = "tbFTPpass";
            this.tbFTPpass.Size = new System.Drawing.Size(133, 20);
            this.tbFTPpass.TabIndex = 9;
            // 
            // btConnect
            // 
            this.btConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConnect.Location = new System.Drawing.Point(589, 272);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(127, 23);
            this.btConnect.TabIndex = 10;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // rtbShow
            // 
            this.rtbShow.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbShow.ForeColor = System.Drawing.Color.LimeGreen;
            this.rtbShow.Location = new System.Drawing.Point(3, 4);
            this.rtbShow.Name = "rtbShow";
            this.rtbShow.Size = new System.Drawing.Size(580, 260);
            this.rtbShow.TabIndex = 11;
            this.rtbShow.Text = "";
            this.rtbShow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbShow_KeyDown);
            this.rtbShow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtbShow_MouseDown);
            this.rtbShow.MouseLeave += new System.EventHandler(this.rtbShow_MouseLeave);
            this.rtbShow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rtbShow_MouseUp);
            // 
            // trefreshlog
            // 
            this.trefreshlog.Interval = 5000;
            this.trefreshlog.Tick += new System.EventHandler(this.trefreshlog_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(722, 278);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(12, 11);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btOptions
            // 
            this.btOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOptions.Location = new System.Drawing.Point(613, 268);
            this.btOptions.Name = "btOptions";
            this.btOptions.Size = new System.Drawing.Size(117, 23);
            this.btOptions.TabIndex = 16;
            this.btOptions.Text = "Options";
            this.btOptions.UseVisualStyleBackColor = true;
            this.btOptions.Click += new System.EventHandler(this.btOptions_Click);
            // 
            // btRestore
            // 
            this.btRestore.Enabled = false;
            this.btRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRestore.Location = new System.Drawing.Point(612, 238);
            this.btRestore.Name = "btRestore";
            this.btRestore.Size = new System.Drawing.Size(118, 23);
            this.btRestore.TabIndex = 15;
            this.btRestore.Text = "Restore";
            this.btRestore.UseVisualStyleBackColor = true;
            this.btRestore.Click += new System.EventHandler(this.btRestore_Click);
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Location = new System.Drawing.Point(612, 209);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(118, 23);
            this.btSave.TabIndex = 14;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btLoad);
            this.groupBox3.Controls.Add(this.lbConfigs);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(606, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(129, 202);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configs";
            // 
            // btLoad
            // 
            this.btLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoad.Location = new System.Drawing.Point(6, 171);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(118, 23);
            this.btLoad.TabIndex = 16;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // lbConfigs
            // 
            this.lbConfigs.FormattingEnabled = true;
            this.lbConfigs.Location = new System.Drawing.Point(10, 18);
            this.lbConfigs.Name = "lbConfigs";
            this.lbConfigs.Size = new System.Drawing.Size(112, 147);
            this.lbConfigs.TabIndex = 0;
            this.lbConfigs.SelectedIndexChanged += new System.EventHandler(this.lbConfigs_SelectedIndexChanged);
            // 
            // rtConfigs
            // 
            this.rtConfigs.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtConfigs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtConfigs.ForeColor = System.Drawing.Color.LimeGreen;
            this.rtConfigs.Location = new System.Drawing.Point(3, 1);
            this.rtConfigs.Name = "rtConfigs";
            this.rtConfigs.Size = new System.Drawing.Size(597, 290);
            this.rtConfigs.TabIndex = 12;
            this.rtConfigs.Text = "";
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Location = new System.Drawing.Point(724, 6);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(22, 22);
            this.btClose.TabIndex = 14;
            this.btClose.Text = "X";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbForm
            // 
            this.lbForm.AutoSize = true;
            this.lbForm.Location = new System.Drawing.Point(12, 9);
            this.lbForm.Name = "lbForm";
            this.lbForm.Size = new System.Drawing.Size(119, 13);
            this.lbForm.TabIndex = 17;
            this.lbForm.Text = "FTP/RCON Admin-Tool";
            // 
            // btSwitch
            // 
            this.btSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSwitch.Location = new System.Drawing.Point(652, 6);
            this.btSwitch.Name = "btSwitch";
            this.btSwitch.Size = new System.Drawing.Size(66, 22);
            this.btSwitch.TabIndex = 18;
            this.btSwitch.Text = "CONFIG";
            this.btSwitch.UseVisualStyleBackColor = false;
            this.btSwitch.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.gbGameConf);
            this.gbOptions.Controls.Add(this.gbFormOption);
            this.gbOptions.Location = new System.Drawing.Point(15, 341);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(731, 164);
            this.gbOptions.TabIndex = 19;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // gbGameConf
            // 
            this.gbGameConf.Controls.Add(this.tbFileName);
            this.gbGameConf.Controls.Add(this.label11);
            this.gbGameConf.Controls.Add(this.cbSaveData);
            this.gbGameConf.Controls.Add(this.cbBackup);
            this.gbGameConf.Controls.Add(this.tbBackupDir);
            this.gbGameConf.Controls.Add(this.label8);
            this.gbGameConf.Controls.Add(this.tbConfigDir);
            this.gbGameConf.Controls.Add(this.label7);
            this.gbGameConf.Controls.Add(this.tbFTPDir);
            this.gbGameConf.Controls.Add(this.lbFTPDirectory);
            this.gbGameConf.Location = new System.Drawing.Point(225, 13);
            this.gbGameConf.Name = "gbGameConf";
            this.gbGameConf.Size = new System.Drawing.Size(493, 145);
            this.gbGameConf.TabIndex = 3;
            this.gbGameConf.TabStop = false;
            this.gbGameConf.Text = "Game config";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(9, 114);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(200, 20);
            this.tbFileName.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Specific Configfilename";
            // 
            // cbSaveData
            // 
            this.cbSaveData.AutoSize = true;
            this.cbSaveData.Checked = true;
            this.cbSaveData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSaveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSaveData.Location = new System.Drawing.Point(270, 19);
            this.cbSaveData.Name = "cbSaveData";
            this.cbSaveData.Size = new System.Drawing.Size(117, 17);
            this.cbSaveData.TabIndex = 2;
            this.cbSaveData.Text = "Save last Logindata";
            this.cbSaveData.UseVisualStyleBackColor = true;
            // 
            // cbBackup
            // 
            this.cbBackup.AutoSize = true;
            this.cbBackup.Checked = true;
            this.cbBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBackup.Location = new System.Drawing.Point(270, 39);
            this.cbBackup.Name = "cbBackup";
            this.cbBackup.Size = new System.Drawing.Size(153, 17);
            this.cbBackup.TabIndex = 6;
            this.cbBackup.Text = "Enable Backup (Configfiles)";
            this.cbBackup.UseVisualStyleBackColor = true;
            // 
            // tbBackupDir
            // 
            this.tbBackupDir.Location = new System.Drawing.Point(270, 75);
            this.tbBackupDir.Name = "tbBackupDir";
            this.tbBackupDir.Size = new System.Drawing.Size(200, 20);
            this.tbBackupDir.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Specific Backupfolder";
            // 
            // tbConfigDir
            // 
            this.tbConfigDir.Location = new System.Drawing.Point(9, 75);
            this.tbConfigDir.Name = "tbConfigDir";
            this.tbConfigDir.Size = new System.Drawing.Size(200, 20);
            this.tbConfigDir.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Specific Configfolder";
            // 
            // tbFTPDir
            // 
            this.tbFTPDir.Location = new System.Drawing.Point(9, 32);
            this.tbFTPDir.Name = "tbFTPDir";
            this.tbFTPDir.Size = new System.Drawing.Size(200, 20);
            this.tbFTPDir.TabIndex = 1;
            this.tbFTPDir.Text = "Minecraft";
            // 
            // lbFTPDirectory
            // 
            this.lbFTPDirectory.AutoSize = true;
            this.lbFTPDirectory.Location = new System.Drawing.Point(6, 16);
            this.lbFTPDirectory.Name = "lbFTPDirectory";
            this.lbFTPDirectory.Size = new System.Drawing.Size(161, 13);
            this.lbFTPDirectory.TabIndex = 0;
            this.lbFTPDirectory.Text = "Gamename (FTP-Directoryname)";
            // 
            // gbFormOption
            // 
            this.gbFormOption.Controls.Add(this.label10);
            this.gbFormOption.Controls.Add(this.label9);
            this.gbFormOption.Controls.Add(this.lbRefresh);
            this.gbFormOption.Controls.Add(this.sbRefreshrate);
            this.gbFormOption.Controls.Add(this.sbOpacity);
            this.gbFormOption.Controls.Add(this.label6);
            this.gbFormOption.Location = new System.Drawing.Point(11, 13);
            this.gbFormOption.Name = "gbFormOption";
            this.gbFormOption.Size = new System.Drawing.Size(200, 145);
            this.gbFormOption.TabIndex = 2;
            this.gbFormOption.TabStop = false;
            this.gbFormOption.Text = "Window Options";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "label9";
            // 
            // lbRefresh
            // 
            this.lbRefresh.AutoSize = true;
            this.lbRefresh.Location = new System.Drawing.Point(6, 59);
            this.lbRefresh.Name = "lbRefresh";
            this.lbRefresh.Size = new System.Drawing.Size(85, 13);
            this.lbRefresh.TabIndex = 3;
            this.lbRefresh.Text = "Console Refresh";
            // 
            // sbRefreshrate
            // 
            this.sbRefreshrate.Location = new System.Drawing.Point(9, 78);
            this.sbRefreshrate.Maximum = 109;
            this.sbRefreshrate.Minimum = 1;
            this.sbRefreshrate.Name = "sbRefreshrate";
            this.sbRefreshrate.Size = new System.Drawing.Size(181, 17);
            this.sbRefreshrate.TabIndex = 2;
            this.sbRefreshrate.Value = 1;
            this.sbRefreshrate.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbRefreshrate_Scroll);
            // 
            // sbOpacity
            // 
            this.sbOpacity.Location = new System.Drawing.Point(9, 34);
            this.sbOpacity.Maximum = 1009;
            this.sbOpacity.Minimum = 250;
            this.sbOpacity.Name = "sbOpacity";
            this.sbOpacity.Size = new System.Drawing.Size(181, 17);
            this.sbOpacity.TabIndex = 0;
            this.sbOpacity.Value = 250;
            this.sbOpacity.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbOpacity_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Opacity";
            // 
            // pnlServerConsole
            // 
            this.pnlServerConsole.Controls.Add(this.groupBox1);
            this.pnlServerConsole.Controls.Add(this.btConnect);
            this.pnlServerConsole.Controls.Add(this.tbsend);
            this.pnlServerConsole.Controls.Add(this.btSend);
            this.pnlServerConsole.Controls.Add(this.rtbShow);
            this.pnlServerConsole.Controls.Add(this.groupBox2);
            this.pnlServerConsole.Controls.Add(this.checkBox1);
            this.pnlServerConsole.Location = new System.Drawing.Point(12, 35);
            this.pnlServerConsole.Name = "pnlServerConsole";
            this.pnlServerConsole.Size = new System.Drawing.Size(741, 298);
            this.pnlServerConsole.TabIndex = 20;
            // 
            // pnlConfig
            // 
            this.pnlConfig.BackColor = System.Drawing.Color.DimGray;
            this.pnlConfig.Controls.Add(this.rtConfigs);
            this.pnlConfig.Controls.Add(this.btOptions);
            this.pnlConfig.Controls.Add(this.groupBox3);
            this.pnlConfig.Controls.Add(this.btSave);
            this.pnlConfig.Controls.Add(this.btRestore);
            this.pnlConfig.Location = new System.Drawing.Point(12, 35);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(741, 298);
            this.pnlConfig.TabIndex = 21;
            // 
            // MFTPrc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(760, 338);
            this.Controls.Add(this.pnlServerConsole);
            this.Controls.Add(this.pnlConfig);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.btSwitch);
            this.Controls.Add(this.lbForm);
            this.Controls.Add(this.btClose);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.Name = "MFTPrc";
            this.Text = "FTP-RemoteConsole by LtP";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.MFTPrc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.gbOptions.ResumeLayout(false);
            this.gbGameConf.ResumeLayout(false);
            this.gbGameConf.PerformLayout();
            this.gbFormOption.ResumeLayout(false);
            this.gbFormOption.PerformLayout();
            this.pnlServerConsole.ResumeLayout(false);
            this.pnlServerConsole.PerformLayout();
            this.pnlConfig.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbsend;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox tbSrvPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbrconPass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFTPIP;
        private System.Windows.Forms.TextBox tbFTPpass;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFTPuser;
        private System.Windows.Forms.RichTextBox rtbShow;
        private System.Windows.Forms.Timer trefreshlog;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btRestore;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtConfigs;
        private System.Windows.Forms.Button btOptions;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.ListBox lbConfigs;
        private System.Windows.Forms.Label lbForm;
        private System.Windows.Forms.Button btSwitch;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.GroupBox gbGameConf;
        private System.Windows.Forms.CheckBox cbBackup;
        private System.Windows.Forms.TextBox tbBackupDir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbConfigDir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFTPDir;
        private System.Windows.Forms.Label lbFTPDirectory;
        private System.Windows.Forms.GroupBox gbFormOption;
        private System.Windows.Forms.CheckBox cbSaveData;
        private System.Windows.Forms.HScrollBar sbOpacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbRefresh;
        private System.Windows.Forms.HScrollBar sbRefreshrate;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlServerConsole;
        private System.Windows.Forms.Panel pnlConfig;
    }
}

