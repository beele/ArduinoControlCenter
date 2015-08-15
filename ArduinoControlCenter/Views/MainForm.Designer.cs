namespace ArduinoControlCenter.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stbrConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbmodel = new System.Windows.Forms.GroupBox();
            this.btnSaveFanSpeedToEEprom = new System.Windows.Forms.Button();
            this.chkStartMinimized = new System.Windows.Forms.CheckBox();
            this.btnSaveColorToEEprom = new System.Windows.Forms.Button();
            this.chkReconnectCom = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbComms = new System.Windows.Forms.ComboBox();
            this.btnCommAction = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabcon = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCurrentManual = new System.Windows.Forms.Label();
            this.pnlColorManual = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlStopColor = new System.Windows.Forms.Panel();
            this.pnlStartColor = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSmoothFade = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlFadeColor = new System.Windows.Forms.Panel();
            this.btnStartFade = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.nsHot = new System.Windows.Forms.NumericUpDown();
            this.nsCold = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.pnlHotColor = new System.Windows.Forms.Panel();
            this.pnlColdColor = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pnlTempColor = new System.Windows.Forms.Panel();
            this.btnStartTempMode = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSmooth = new System.Windows.Forms.Label();
            this.tbSmoothScreen = new System.Windows.Forms.TrackBar();
            this.lblFPS = new System.Windows.Forms.Label();
            this.chkEnhance = new System.Windows.Forms.CheckBox();
            this.lblCurrentAuto = new System.Windows.Forms.Label();
            this.lblAutoInfo = new System.Windows.Forms.Label();
            this.pnlColorAuto = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPWM5 = new System.Windows.Forms.Label();
            this.lblPWM4 = new System.Windows.Forms.Label();
            this.lblPWM3 = new System.Windows.Forms.Label();
            this.lblPWM2 = new System.Windows.Forms.Label();
            this.lblPWM1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblPWM = new System.Windows.Forms.Label();
            this.prgPWM = new System.Windows.Forms.ProgressBar();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ns5 = new System.Windows.Forms.NumericUpDown();
            this.ns4 = new System.Windows.Forms.NumericUpDown();
            this.ns3 = new System.Windows.Forms.NumericUpDown();
            this.ns2 = new System.Windows.Forms.NumericUpDown();
            this.ns1 = new System.Windows.Forms.NumericUpDown();
            this.tb5 = new System.Windows.Forms.TrackBar();
            this.tb4 = new System.Windows.Forms.TrackBar();
            this.tb3 = new System.Windows.Forms.TrackBar();
            this.tb2 = new System.Windows.Forms.TrackBar();
            this.tb1 = new System.Windows.Forms.TrackBar();
            this.label19 = new System.Windows.Forms.Label();
            this.chkQuietMode = new System.Windows.Forms.CheckBox();
            this.nsQuietModeSpeed = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.lblCore4 = new System.Windows.Forms.Label();
            this.lblCore3 = new System.Windows.Forms.Label();
            this.lblCore2 = new System.Windows.Forms.Label();
            this.lblCore1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prgCore4 = new System.Windows.Forms.ProgressBar();
            this.prgCore3 = new System.Windows.Forms.ProgressBar();
            this.prgCore2 = new System.Windows.Forms.ProgressBar();
            this.prgCore1 = new System.Windows.Forms.ProgressBar();
            this.ti1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1.SuspendLayout();
            this.gbmodel.SuspendLayout();
            this.tabcon.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSmoothFade)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsHot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsCold)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSmoothScreen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ns5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ns4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ns3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ns2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ns1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsQuietModeSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbrConnection});
            this.statusStrip1.Location = new System.Drawing.Point(0, 861);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1868, 37);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stbrConnection
            // 
            this.stbrConnection.Name = "stbrConnection";
            this.stbrConnection.Size = new System.Drawing.Size(174, 32);
            this.stbrConnection.Text = "Not connected";
            // 
            // gbmodel
            // 
            this.gbmodel.Controls.Add(this.btnSaveFanSpeedToEEprom);
            this.gbmodel.Controls.Add(this.chkStartMinimized);
            this.gbmodel.Controls.Add(this.btnSaveColorToEEprom);
            this.gbmodel.Controls.Add(this.chkReconnectCom);
            this.gbmodel.Controls.Add(this.btnRefresh);
            this.gbmodel.Controls.Add(this.cmbComms);
            this.gbmodel.Controls.Add(this.btnCommAction);
            this.gbmodel.Controls.Add(this.label4);
            this.gbmodel.Location = new System.Drawing.Point(1430, 23);
            this.gbmodel.Margin = new System.Windows.Forms.Padding(6);
            this.gbmodel.Name = "gbmodel";
            this.gbmodel.Padding = new System.Windows.Forms.Padding(6);
            this.gbmodel.Size = new System.Drawing.Size(416, 810);
            this.gbmodel.TabIndex = 9;
            this.gbmodel.TabStop = false;
            this.gbmodel.Text = "Arduino Control";
            // 
            // btnSaveFanSpeedToEEprom
            // 
            this.btnSaveFanSpeedToEEprom.Location = new System.Drawing.Point(18, 491);
            this.btnSaveFanSpeedToEEprom.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaveFanSpeedToEEprom.Name = "btnSaveFanSpeedToEEprom";
            this.btnSaveFanSpeedToEEprom.Size = new System.Drawing.Size(386, 44);
            this.btnSaveFanSpeedToEEprom.TabIndex = 21;
            this.btnSaveFanSpeedToEEprom.Text = "Save static fan speed to EEprom";
            this.btnSaveFanSpeedToEEprom.UseVisualStyleBackColor = true;
            // 
            // chkStartMinimized
            // 
            this.chkStartMinimized.AutoSize = true;
            this.chkStartMinimized.Location = new System.Drawing.Point(212, 769);
            this.chkStartMinimized.Margin = new System.Windows.Forms.Padding(6);
            this.chkStartMinimized.Name = "chkStartMinimized";
            this.chkStartMinimized.Size = new System.Drawing.Size(192, 29);
            this.chkStartMinimized.TabIndex = 20;
            this.chkStartMinimized.Text = "Start Minimized";
            this.chkStartMinimized.UseVisualStyleBackColor = true;
            this.chkStartMinimized.CheckedChanged += new System.EventHandler(this.chkStartMinimized_CheckedChanged);
            // 
            // btnSaveColorToEEprom
            // 
            this.btnSaveColorToEEprom.Location = new System.Drawing.Point(18, 417);
            this.btnSaveColorToEEprom.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaveColorToEEprom.Name = "btnSaveColorToEEprom";
            this.btnSaveColorToEEprom.Size = new System.Drawing.Size(386, 44);
            this.btnSaveColorToEEprom.TabIndex = 15;
            this.btnSaveColorToEEprom.Text = "Save static color to EEprom";
            this.btnSaveColorToEEprom.UseVisualStyleBackColor = true;
            this.btnSaveColorToEEprom.Click += new System.EventHandler(this.btnSaveColorToEEprom_Click);
            // 
            // chkReconnectCom
            // 
            this.chkReconnectCom.AutoSize = true;
            this.chkReconnectCom.Location = new System.Drawing.Point(22, 274);
            this.chkReconnectCom.Margin = new System.Windows.Forms.Padding(6);
            this.chkReconnectCom.Name = "chkReconnectCom";
            this.chkReconnectCom.Size = new System.Drawing.Size(190, 29);
            this.chkReconnectCom.TabIndex = 18;
            this.chkReconnectCom.Text = "Auto-reconnect";
            this.chkReconnectCom.UseVisualStyleBackColor = true;
            this.chkReconnectCom.CheckedChanged += new System.EventHandler(this.chkReconnectCom_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(356, 206);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(48, 44);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbComms
            // 
            this.cmbComms.FormattingEnabled = true;
            this.cmbComms.Location = new System.Drawing.Point(22, 210);
            this.cmbComms.Margin = new System.Windows.Forms.Padding(6);
            this.cmbComms.Name = "cmbComms";
            this.cmbComms.Size = new System.Drawing.Size(318, 33);
            this.cmbComms.TabIndex = 11;
            this.cmbComms.Text = "Select com port";
            // 
            // btnCommAction
            // 
            this.btnCommAction.Location = new System.Drawing.Point(18, 343);
            this.btnCommAction.Margin = new System.Windows.Forms.Padding(6);
            this.btnCommAction.Name = "btnCommAction";
            this.btnCommAction.Size = new System.Drawing.Size(386, 44);
            this.btnCommAction.TabIndex = 9;
            this.btnCommAction.Text = "Connect to Arduino";
            this.btnCommAction.UseVisualStyleBackColor = true;
            this.btnCommAction.Click += new System.EventHandler(this.btnCommAction_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 104);
            this.label4.TabIndex = 3;
            this.label4.Text = "Serial port and connection options.\r\n\r\nYou can also save some values to the \r\nard" +
    "uino for use without the software.\r\n";
            // 
            // tabcon
            // 
            this.tabcon.Controls.Add(this.tabPage1);
            this.tabcon.Controls.Add(this.tabPage3);
            this.tabcon.Controls.Add(this.tabPage4);
            this.tabcon.Controls.Add(this.tabPage2);
            this.tabcon.Location = new System.Drawing.Point(26, 38);
            this.tabcon.Margin = new System.Windows.Forms.Padding(6);
            this.tabcon.Name = "tabcon";
            this.tabcon.SelectedIndex = 0;
            this.tabcon.Size = new System.Drawing.Size(600, 749);
            this.tabcon.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.lblCurrentManual);
            this.tabPage1.Controls.Add(this.pnlColorManual);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(584, 702);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manual";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 19);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(560, 207);
            this.label12.TabIndex = 16;
            this.label12.Text = "Static color mode. This will onlmy display one static color.\r\n\r\nClick on the chos" +
    "en color field to change it.\r\n\r\nThis mode is active by default.";
            // 
            // lblCurrentManual
            // 
            this.lblCurrentManual.AutoSize = true;
            this.lblCurrentManual.Location = new System.Drawing.Point(187, 283);
            this.lblCurrentManual.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCurrentManual.Name = "lblCurrentManual";
            this.lblCurrentManual.Size = new System.Drawing.Size(139, 25);
            this.lblCurrentManual.TabIndex = 14;
            this.lblCurrentManual.Text = "Chosen color";
            // 
            // pnlColorManual
            // 
            this.pnlColorManual.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlColorManual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColorManual.Location = new System.Drawing.Point(187, 319);
            this.pnlColorManual.Margin = new System.Windows.Forms.Padding(6);
            this.pnlColorManual.Name = "pnlColorManual";
            this.pnlColorManual.Size = new System.Drawing.Size(144, 139);
            this.pnlColorManual.TabIndex = 12;
            this.pnlColorManual.Click += new System.EventHandler(this.pnlColorManual_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.pnlStopColor);
            this.tabPage3.Controls.Add(this.pnlStartColor);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.tbSmoothFade);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.pnlFadeColor);
            this.tabPage3.Controls.Add(this.btnStartFade);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(584, 702);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Color fade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 129);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 25);
            this.label11.TabIndex = 32;
            this.label11.Text = "stop";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 129);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "start";
            // 
            // pnlStopColor
            // 
            this.pnlStopColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlStopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStopColor.Location = new System.Drawing.Point(142, 162);
            this.pnlStopColor.Margin = new System.Windows.Forms.Padding(6);
            this.pnlStopColor.Name = "pnlStopColor";
            this.pnlStopColor.Size = new System.Drawing.Size(68, 65);
            this.pnlStopColor.TabIndex = 26;
            this.pnlStopColor.Click += new System.EventHandler(this.pnlStopColor_Click);
            // 
            // pnlStartColor
            // 
            this.pnlStartColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlStartColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStartColor.Location = new System.Drawing.Point(24, 162);
            this.pnlStartColor.Margin = new System.Windows.Forms.Padding(6);
            this.pnlStartColor.Name = "pnlStartColor";
            this.pnlStartColor.Size = new System.Drawing.Size(68, 65);
            this.pnlStartColor.TabIndex = 25;
            this.pnlStartColor.Click += new System.EventHandler(this.pnlStartColor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 293);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "Pattern duration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 381);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "30 sec";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 381);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "1 sec";
            // 
            // tbSmoothFade
            // 
            this.tbSmoothFade.LargeChange = 50;
            this.tbSmoothFade.Location = new System.Drawing.Point(22, 330);
            this.tbSmoothFade.Margin = new System.Windows.Forms.Padding(6);
            this.tbSmoothFade.Name = "tbSmoothFade";
            this.tbSmoothFade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSmoothFade.Size = new System.Drawing.Size(476, 90);
            this.tbSmoothFade.SmallChange = 10;
            this.tbSmoothFade.TabIndex = 27;
            this.tbSmoothFade.TickFrequency = 100;
            this.tbSmoothFade.Scroll += new System.EventHandler(this.tbSmoothFade_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 515);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Current color";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(560, 100);
            this.label8.TabIndex = 25;
            this.label8.Text = "Set the color to follow a pattern that you have defined.\r\n\r\nBelow are some option" +
    "s to define the pattern:";
            // 
            // pnlFadeColor
            // 
            this.pnlFadeColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlFadeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFadeColor.Location = new System.Drawing.Point(12, 551);
            this.pnlFadeColor.Margin = new System.Windows.Forms.Padding(6);
            this.pnlFadeColor.Name = "pnlFadeColor";
            this.pnlFadeColor.Size = new System.Drawing.Size(144, 139);
            this.pnlFadeColor.TabIndex = 24;
            // 
            // btnStartFade
            // 
            this.btnStartFade.Location = new System.Drawing.Point(422, 646);
            this.btnStartFade.Margin = new System.Windows.Forms.Padding(6);
            this.btnStartFade.Name = "btnStartFade";
            this.btnStartFade.Size = new System.Drawing.Size(150, 44);
            this.btnStartFade.TabIndex = 23;
            this.btnStartFade.Text = "Start";
            this.btnStartFade.UseVisualStyleBackColor = true;
            this.btnStartFade.Click += new System.EventHandler(this.btnStartFade_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.label25);
            this.tabPage4.Controls.Add(this.label24);
            this.tabPage4.Controls.Add(this.nsHot);
            this.tabPage4.Controls.Add(this.nsCold);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Controls.Add(this.label23);
            this.tabPage4.Controls.Add(this.pnlHotColor);
            this.tabPage4.Controls.Add(this.pnlColdColor);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.pnlTempColor);
            this.tabPage4.Controls.Add(this.btnStartTempMode);
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage4.Size = new System.Drawing.Size(584, 702);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Temp";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(442, 394);
            this.label25.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 25);
            this.label25.TabIndex = 40;
            this.label25.Text = "°C";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(211, 393);
            this.label24.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 25);
            this.label24.TabIndex = 39;
            this.label24.Text = "°C";
            // 
            // nsHot
            // 
            this.nsHot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsHot.Location = new System.Drawing.Point(345, 391);
            this.nsHot.Margin = new System.Windows.Forms.Padding(6);
            this.nsHot.Name = "nsHot";
            this.nsHot.Size = new System.Drawing.Size(90, 31);
            this.nsHot.TabIndex = 38;
            this.nsHot.ValueChanged += new System.EventHandler(this.nsHot_ValueChanged);
            // 
            // nsCold
            // 
            this.nsCold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsCold.Location = new System.Drawing.Point(113, 391);
            this.nsCold.Margin = new System.Windows.Forms.Padding(6);
            this.nsCold.Name = "nsCold";
            this.nsCold.Size = new System.Drawing.Size(90, 31);
            this.nsCold.TabIndex = 37;
            this.nsCold.ValueChanged += new System.EventHandler(this.nsCold_ValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(365, 281);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 25);
            this.label22.TabIndex = 36;
            this.label22.Text = "Hot";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(132, 281);
            this.label23.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 25);
            this.label23.TabIndex = 35;
            this.label23.Text = "Cold";
            // 
            // pnlHotColor
            // 
            this.pnlHotColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlHotColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHotColor.Location = new System.Drawing.Point(353, 314);
            this.pnlHotColor.Margin = new System.Windows.Forms.Padding(6);
            this.pnlHotColor.Name = "pnlHotColor";
            this.pnlHotColor.Size = new System.Drawing.Size(68, 65);
            this.pnlHotColor.TabIndex = 34;
            this.pnlHotColor.Click += new System.EventHandler(this.pnlHotColor_Click);
            // 
            // pnlColdColor
            // 
            this.pnlColdColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlColdColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColdColor.Location = new System.Drawing.Point(125, 314);
            this.pnlColdColor.Margin = new System.Windows.Forms.Padding(6);
            this.pnlColdColor.Name = "pnlColdColor";
            this.pnlColdColor.Size = new System.Drawing.Size(68, 65);
            this.pnlColdColor.TabIndex = 33;
            this.pnlColdColor.Click += new System.EventHandler(this.pnlColdColor_Click);
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 19);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(560, 207);
            this.label21.TabIndex = 30;
            this.label21.Text = "Make the RGB color update to follow the CPU temperature.\r\n(Based on the core with" +
    " the highest temp)\r\n\r\nBelow you can select the start and end temperatures\r\nand c" +
    "olors.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 515);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(136, 25);
            this.label20.TabIndex = 29;
            this.label20.Text = "Current color";
            // 
            // pnlTempColor
            // 
            this.pnlTempColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTempColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTempColor.Location = new System.Drawing.Point(12, 551);
            this.pnlTempColor.Margin = new System.Windows.Forms.Padding(6);
            this.pnlTempColor.Name = "pnlTempColor";
            this.pnlTempColor.Size = new System.Drawing.Size(144, 139);
            this.pnlTempColor.TabIndex = 28;
            // 
            // btnStartTempMode
            // 
            this.btnStartTempMode.Location = new System.Drawing.Point(422, 646);
            this.btnStartTempMode.Margin = new System.Windows.Forms.Padding(6);
            this.btnStartTempMode.Name = "btnStartTempMode";
            this.btnStartTempMode.Size = new System.Drawing.Size(150, 44);
            this.btnStartTempMode.TabIndex = 27;
            this.btnStartTempMode.Text = "Start";
            this.btnStartTempMode.UseVisualStyleBackColor = true;
            this.btnStartTempMode.Click += new System.EventHandler(this.btnStartTempMode_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.lblMax);
            this.tabPage2.Controls.Add(this.lblMin);
            this.tabPage2.Controls.Add(this.lblSmooth);
            this.tabPage2.Controls.Add(this.tbSmoothScreen);
            this.tabPage2.Controls.Add(this.lblFPS);
            this.tabPage2.Controls.Add(this.chkEnhance);
            this.tabPage2.Controls.Add(this.lblCurrentAuto);
            this.tabPage2.Controls.Add(this.lblAutoInfo);
            this.tabPage2.Controls.Add(this.pnlColorAuto);
            this.tabPage2.Controls.Add(this.btnStart);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(584, 702);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Screen";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(446, 365);
            this.lblMax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(52, 25);
            this.lblMax.TabIndex = 22;
            this.lblMax.Text = "max";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(24, 365);
            this.lblMin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(46, 25);
            this.lblMin.TabIndex = 21;
            this.lblMin.Text = "min";
            // 
            // lblSmooth
            // 
            this.lblSmooth.AutoSize = true;
            this.lblSmooth.Location = new System.Drawing.Point(22, 277);
            this.lblSmooth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSmooth.Name = "lblSmooth";
            this.lblSmooth.Size = new System.Drawing.Size(153, 25);
            this.lblSmooth.TabIndex = 20;
            this.lblSmooth.Text = "Capture speed";
            // 
            // tbSmoothScreen
            // 
            this.tbSmoothScreen.LargeChange = 50;
            this.tbSmoothScreen.Location = new System.Drawing.Point(22, 313);
            this.tbSmoothScreen.Margin = new System.Windows.Forms.Padding(6);
            this.tbSmoothScreen.Name = "tbSmoothScreen";
            this.tbSmoothScreen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSmoothScreen.Size = new System.Drawing.Size(476, 90);
            this.tbSmoothScreen.SmallChange = 10;
            this.tbSmoothScreen.TabIndex = 19;
            this.tbSmoothScreen.TickFrequency = 100;
            this.tbSmoothScreen.Scroll += new System.EventHandler(this.tbSmooth_Scroll_1);
            // 
            // lblFPS
            // 
            this.lblFPS.AutoSize = true;
            this.lblFPS.Location = new System.Drawing.Point(162, 549);
            this.lblFPS.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(72, 25);
            this.lblFPS.TabIndex = 18;
            this.lblFPS.Text = "FPS: -";
            // 
            // chkEnhance
            // 
            this.chkEnhance.AutoSize = true;
            this.chkEnhance.Checked = true;
            this.chkEnhance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnhance.Location = new System.Drawing.Point(22, 171);
            this.chkEnhance.Margin = new System.Windows.Forms.Padding(6);
            this.chkEnhance.Name = "chkEnhance";
            this.chkEnhance.Size = new System.Drawing.Size(182, 29);
            this.chkEnhance.TabIndex = 17;
            this.chkEnhance.Text = "Enhance color";
            this.chkEnhance.UseVisualStyleBackColor = true;
            this.chkEnhance.CheckedChanged += new System.EventHandler(this.chkEnhance_CheckedChanged_1);
            // 
            // lblCurrentAuto
            // 
            this.lblCurrentAuto.AutoSize = true;
            this.lblCurrentAuto.Location = new System.Drawing.Point(12, 515);
            this.lblCurrentAuto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCurrentAuto.Name = "lblCurrentAuto";
            this.lblCurrentAuto.Size = new System.Drawing.Size(136, 25);
            this.lblCurrentAuto.TabIndex = 16;
            this.lblCurrentAuto.Text = "Current color";
            // 
            // lblAutoInfo
            // 
            this.lblAutoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoInfo.Location = new System.Drawing.Point(12, 19);
            this.lblAutoInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAutoInfo.Name = "lblAutoInfo";
            this.lblAutoInfo.Size = new System.Drawing.Size(560, 75);
            this.lblAutoInfo.TabIndex = 15;
            this.lblAutoInfo.Text = "Set the RGB color to the average screen color.\r\n\r\nBelow are some options you can " +
    "set:";
            // 
            // pnlColorAuto
            // 
            this.pnlColorAuto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlColorAuto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColorAuto.Location = new System.Drawing.Point(12, 551);
            this.pnlColorAuto.Margin = new System.Windows.Forms.Padding(6);
            this.pnlColorAuto.Name = "pnlColorAuto";
            this.pnlColorAuto.Size = new System.Drawing.Size(144, 139);
            this.pnlColorAuto.TabIndex = 14;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(422, 646);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 44);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabcon);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(656, 810);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RGB Controls";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.lblPWM5);
            this.groupBox2.Controls.Add(this.lblPWM4);
            this.groupBox2.Controls.Add(this.lblPWM3);
            this.groupBox2.Controls.Add(this.lblPWM2);
            this.groupBox2.Controls.Add(this.lblPWM1);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lblPWM);
            this.groupBox2.Controls.Add(this.prgPWM);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.ns5);
            this.groupBox2.Controls.Add(this.ns4);
            this.groupBox2.Controls.Add(this.ns3);
            this.groupBox2.Controls.Add(this.ns2);
            this.groupBox2.Controls.Add(this.ns1);
            this.groupBox2.Controls.Add(this.tb5);
            this.groupBox2.Controls.Add(this.tb4);
            this.groupBox2.Controls.Add(this.tb3);
            this.groupBox2.Controls.Add(this.tb2);
            this.groupBox2.Controls.Add(this.tb1);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.chkQuietMode);
            this.groupBox2.Controls.Add(this.nsQuietModeSpeed);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lblCore4);
            this.groupBox2.Controls.Add(this.lblCore3);
            this.groupBox2.Controls.Add(this.lblCore2);
            this.groupBox2.Controls.Add(this.lblCore1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.prgCore4);
            this.groupBox2.Controls.Add(this.prgCore3);
            this.groupBox2.Controls.Add(this.prgCore2);
            this.groupBox2.Controls.Add(this.prgCore1);
            this.groupBox2.Location = new System.Drawing.Point(692, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(726, 810);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fan Control";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(9, 734);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 2);
            this.panel2.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(16, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 2);
            this.panel1.TabIndex = 38;
            // 
            // lblPWM5
            // 
            this.lblPWM5.AutoSize = true;
            this.lblPWM5.Location = new System.Drawing.Point(606, 345);
            this.lblPWM5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPWM5.Name = "lblPWM5";
            this.lblPWM5.Size = new System.Drawing.Size(43, 25);
            this.lblPWM5.TabIndex = 37;
            this.lblPWM5.Text = "#%";
            // 
            // lblPWM4
            // 
            this.lblPWM4.AutoSize = true;
            this.lblPWM4.Location = new System.Drawing.Point(480, 345);
            this.lblPWM4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPWM4.Name = "lblPWM4";
            this.lblPWM4.Size = new System.Drawing.Size(43, 25);
            this.lblPWM4.TabIndex = 36;
            this.lblPWM4.Text = "#%";
            // 
            // lblPWM3
            // 
            this.lblPWM3.AutoSize = true;
            this.lblPWM3.Location = new System.Drawing.Point(358, 345);
            this.lblPWM3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPWM3.Name = "lblPWM3";
            this.lblPWM3.Size = new System.Drawing.Size(43, 25);
            this.lblPWM3.TabIndex = 35;
            this.lblPWM3.Text = "#%";
            // 
            // lblPWM2
            // 
            this.lblPWM2.AutoSize = true;
            this.lblPWM2.Location = new System.Drawing.Point(230, 345);
            this.lblPWM2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPWM2.Name = "lblPWM2";
            this.lblPWM2.Size = new System.Drawing.Size(43, 25);
            this.lblPWM2.TabIndex = 34;
            this.lblPWM2.Text = "#%";
            // 
            // lblPWM1
            // 
            this.lblPWM1.AutoSize = true;
            this.lblPWM1.Location = new System.Drawing.Point(108, 345);
            this.lblPWM1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPWM1.Name = "lblPWM1";
            this.lblPWM1.Size = new System.Drawing.Size(43, 25);
            this.lblPWM1.TabIndex = 33;
            this.lblPWM1.Text = "#%";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(40, 763);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 25);
            this.label17.TabIndex = 32;
            this.label17.Text = "PWM";
            // 
            // lblPWM
            // 
            this.lblPWM.AutoSize = true;
            this.lblPWM.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPWM.Location = new System.Drawing.Point(634, 763);
            this.lblPWM.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPWM.Name = "lblPWM";
            this.lblPWM.Size = new System.Drawing.Size(49, 25);
            this.lblPWM.TabIndex = 31;
            this.lblPWM.Text = "# %";
            // 
            // prgPWM
            // 
            this.prgPWM.Location = new System.Drawing.Point(110, 758);
            this.prgPWM.Margin = new System.Windows.Forms.Padding(6);
            this.prgPWM.Name = "prgPWM";
            this.prgPWM.Size = new System.Drawing.Size(520, 36);
            this.prgPWM.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(687, 632);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 25);
            this.label16.TabIndex = 29;
            this.label16.Text = "°C";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 631);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 25);
            this.label15.TabIndex = 28;
            this.label15.Text = "Temp";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 346);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 25);
            this.label14.TabIndex = 27;
            this.label14.Text = "PWM";
            // 
            // ns5
            // 
            this.ns5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ns5.Location = new System.Drawing.Point(588, 628);
            this.ns5.Margin = new System.Windows.Forms.Padding(6);
            this.ns5.Name = "ns5";
            this.ns5.Size = new System.Drawing.Size(90, 31);
            this.ns5.TabIndex = 26;
            this.ns5.ValueChanged += new System.EventHandler(this.ns5_ValueChanged);
            // 
            // ns4
            // 
            this.ns4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ns4.Location = new System.Drawing.Point(462, 628);
            this.ns4.Margin = new System.Windows.Forms.Padding(6);
            this.ns4.Name = "ns4";
            this.ns4.Size = new System.Drawing.Size(90, 31);
            this.ns4.TabIndex = 25;
            this.ns4.ValueChanged += new System.EventHandler(this.ns4_ValueChanged);
            // 
            // ns3
            // 
            this.ns3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ns3.Location = new System.Drawing.Point(340, 628);
            this.ns3.Margin = new System.Windows.Forms.Padding(6);
            this.ns3.Name = "ns3";
            this.ns3.Size = new System.Drawing.Size(90, 31);
            this.ns3.TabIndex = 24;
            this.ns3.ValueChanged += new System.EventHandler(this.ns3_ValueChanged);
            // 
            // ns2
            // 
            this.ns2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ns2.Location = new System.Drawing.Point(212, 628);
            this.ns2.Margin = new System.Windows.Forms.Padding(6);
            this.ns2.Name = "ns2";
            this.ns2.Size = new System.Drawing.Size(90, 31);
            this.ns2.TabIndex = 23;
            this.ns2.ValueChanged += new System.EventHandler(this.ns2_ValueChanged);
            // 
            // ns1
            // 
            this.ns1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ns1.Location = new System.Drawing.Point(90, 628);
            this.ns1.Margin = new System.Windows.Forms.Padding(6);
            this.ns1.Name = "ns1";
            this.ns1.Size = new System.Drawing.Size(90, 31);
            this.ns1.TabIndex = 22;
            this.ns1.ValueChanged += new System.EventHandler(this.ns1_ValueChanged);
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(596, 362);
            this.tb5.Margin = new System.Windows.Forms.Padding(6);
            this.tb5.Maximum = 100;
            this.tb5.Name = "tb5";
            this.tb5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tb5.Size = new System.Drawing.Size(90, 269);
            this.tb5.TabIndex = 21;
            this.tb5.TickFrequency = 5;
            this.tb5.ValueChanged += new System.EventHandler(this.tb5_ValueChanged);
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(470, 362);
            this.tb4.Margin = new System.Windows.Forms.Padding(6);
            this.tb4.Maximum = 100;
            this.tb4.Name = "tb4";
            this.tb4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tb4.Size = new System.Drawing.Size(90, 269);
            this.tb4.TabIndex = 20;
            this.tb4.TickFrequency = 5;
            this.tb4.ValueChanged += new System.EventHandler(this.tb4_ValueChanged);
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(348, 362);
            this.tb3.Margin = new System.Windows.Forms.Padding(6);
            this.tb3.Maximum = 100;
            this.tb3.Name = "tb3";
            this.tb3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tb3.Size = new System.Drawing.Size(90, 269);
            this.tb3.TabIndex = 19;
            this.tb3.TickFrequency = 5;
            this.tb3.ValueChanged += new System.EventHandler(this.tb3_ValueChanged);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(220, 362);
            this.tb2.Margin = new System.Windows.Forms.Padding(6);
            this.tb2.Maximum = 100;
            this.tb2.Name = "tb2";
            this.tb2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tb2.Size = new System.Drawing.Size(90, 269);
            this.tb2.TabIndex = 18;
            this.tb2.TickFrequency = 5;
            this.tb2.ValueChanged += new System.EventHandler(this.tb2_ValueChanged);
            // 
            // tb1
            // 
            this.tb1.LargeChange = 10;
            this.tb1.Location = new System.Drawing.Point(98, 362);
            this.tb1.Margin = new System.Windows.Forms.Padding(6);
            this.tb1.Maximum = 100;
            this.tb1.Name = "tb1";
            this.tb1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tb1.Size = new System.Drawing.Size(90, 269);
            this.tb1.SmallChange = 5;
            this.tb1.TabIndex = 17;
            this.tb1.TickFrequency = 5;
            this.tb1.ValueChanged += new System.EventHandler(this.tb1_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(280, 682);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(215, 25);
            this.label19.TabIndex = 15;
            this.label19.Text = "constant pwm speed:";
            // 
            // chkQuietMode
            // 
            this.chkQuietMode.AutoSize = true;
            this.chkQuietMode.Location = new System.Drawing.Point(111, 681);
            this.chkQuietMode.Margin = new System.Windows.Forms.Padding(6);
            this.chkQuietMode.Name = "chkQuietMode";
            this.chkQuietMode.Size = new System.Drawing.Size(157, 29);
            this.chkQuietMode.TabIndex = 14;
            this.chkQuietMode.Text = "Static mode";
            this.chkQuietMode.UseVisualStyleBackColor = true;
            this.chkQuietMode.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // nsQuietModeSpeed
            // 
            this.nsQuietModeSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsQuietModeSpeed.Location = new System.Drawing.Point(507, 679);
            this.nsQuietModeSpeed.Margin = new System.Windows.Forms.Padding(6);
            this.nsQuietModeSpeed.Name = "nsQuietModeSpeed";
            this.nsQuietModeSpeed.Size = new System.Drawing.Size(112, 31);
            this.nsQuietModeSpeed.TabIndex = 13;
            this.nsQuietModeSpeed.ValueChanged += new System.EventHandler(this.nsQuietModeSpeed_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 38);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(527, 25);
            this.label18.TabIndex = 12;
            this.label18.Text = "Control the fan speed via a custom temperature graph";
            // 
            // lblCore4
            // 
            this.lblCore4.AutoSize = true;
            this.lblCore4.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCore4.Location = new System.Drawing.Point(635, 258);
            this.lblCore4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCore4.Name = "lblCore4";
            this.lblCore4.Size = new System.Drawing.Size(53, 25);
            this.lblCore4.TabIndex = 11;
            this.lblCore4.Text = "# °C";
            // 
            // lblCore3
            // 
            this.lblCore3.AutoSize = true;
            this.lblCore3.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCore3.Location = new System.Drawing.Point(636, 204);
            this.lblCore3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCore3.Name = "lblCore3";
            this.lblCore3.Size = new System.Drawing.Size(53, 25);
            this.lblCore3.TabIndex = 10;
            this.lblCore3.Text = "# °C";
            // 
            // lblCore2
            // 
            this.lblCore2.AutoSize = true;
            this.lblCore2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCore2.Location = new System.Drawing.Point(634, 146);
            this.lblCore2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCore2.Name = "lblCore2";
            this.lblCore2.Size = new System.Drawing.Size(53, 25);
            this.lblCore2.TabIndex = 9;
            this.lblCore2.Text = "# °C";
            // 
            // lblCore1
            // 
            this.lblCore1.AutoSize = true;
            this.lblCore1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCore1.Location = new System.Drawing.Point(635, 90);
            this.lblCore1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCore1.Name = "lblCore1";
            this.lblCore1.Size = new System.Drawing.Size(53, 25);
            this.lblCore1.TabIndex = 8;
            this.lblCore1.Text = "# °C";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 258);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 25);
            this.label13.TabIndex = 7;
            this.label13.Text = "Core 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Core 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Core 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Core 1";
            // 
            // prgCore4
            // 
            this.prgCore4.Location = new System.Drawing.Point(110, 252);
            this.prgCore4.Margin = new System.Windows.Forms.Padding(6);
            this.prgCore4.Name = "prgCore4";
            this.prgCore4.Size = new System.Drawing.Size(520, 36);
            this.prgCore4.TabIndex = 3;
            // 
            // prgCore3
            // 
            this.prgCore3.Location = new System.Drawing.Point(110, 197);
            this.prgCore3.Margin = new System.Windows.Forms.Padding(6);
            this.prgCore3.Name = "prgCore3";
            this.prgCore3.Size = new System.Drawing.Size(520, 36);
            this.prgCore3.TabIndex = 2;
            // 
            // prgCore2
            // 
            this.prgCore2.Location = new System.Drawing.Point(110, 141);
            this.prgCore2.Margin = new System.Windows.Forms.Padding(6);
            this.prgCore2.Name = "prgCore2";
            this.prgCore2.Size = new System.Drawing.Size(520, 36);
            this.prgCore2.TabIndex = 1;
            // 
            // prgCore1
            // 
            this.prgCore1.Location = new System.Drawing.Point(110, 85);
            this.prgCore1.Margin = new System.Windows.Forms.Padding(6);
            this.prgCore1.Name = "prgCore1";
            this.prgCore1.Size = new System.Drawing.Size(520, 36);
            this.prgCore1.TabIndex = 0;
            // 
            // ti1
            // 
            this.ti1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ti1.BalloonTipText = "Arduino Control Center application is still running, double click to show the app" +
    "lication!";
            this.ti1.BalloonTipTitle = "Arduino Control Center";
            this.ti1.ContextMenuStrip = this.cms1;
            this.ti1.Icon = ((System.Drawing.Icon)(resources.GetObject("ti1.Icon")));
            this.ti1.Text = "Arduino Control Center";
            this.ti1.Visible = true;
            this.ti1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // cms1
            // 
            this.cms1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cms1.Name = "cms1";
            this.cms1.Size = new System.Drawing.Size(86, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1868, 898);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbmodel);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Arduino Control Center";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbmodel.ResumeLayout(false);
            this.gbmodel.PerformLayout();
            this.tabcon.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSmoothFade)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsHot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsCold)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSmoothScreen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ns5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ns4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ns3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ns2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ns1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsQuietModeSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox gbmodel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCommAction;
        private System.Windows.Forms.Button btnRefresh;

        //Public fields for access in controller
        public System.Windows.Forms.ComboBox cmbComms;
        public System.Windows.Forms.ToolStripStatusLabel stbrConnection;
        private System.Windows.Forms.TabControl tabcon;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblCurrentManual;
        private System.Windows.Forms.Panel pnlColorManual;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSmooth;
        public System.Windows.Forms.TrackBar tbSmoothScreen;
        private System.Windows.Forms.Label lblFPS;
        private System.Windows.Forms.CheckBox chkEnhance;
        private System.Windows.Forms.Label lblCurrentAuto;
        private System.Windows.Forms.Label lblAutoInfo;
        private System.Windows.Forms.Panel pnlColorAuto;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TrackBar tbSmoothFade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlFadeColor;
        private System.Windows.Forms.Button btnStartFade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlStopColor;
        private System.Windows.Forms.Panel pnlStartColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSaveColorToEEprom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox chkReconnectCom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar prgCore1;
        private System.Windows.Forms.Label lblCore4;
        private System.Windows.Forms.Label lblCore3;
        private System.Windows.Forms.Label lblCore2;
        private System.Windows.Forms.Label lblCore1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar prgCore4;
        private System.Windows.Forms.ProgressBar prgCore3;
        private System.Windows.Forms.ProgressBar prgCore2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox chkQuietMode;
        private System.Windows.Forms.NumericUpDown nsQuietModeSpeed;
        private System.Windows.Forms.Label label18;
        //private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        //private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        //private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        //private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TrackBar tb5;
        private System.Windows.Forms.TrackBar tb4;
        private System.Windows.Forms.TrackBar tb3;
        private System.Windows.Forms.TrackBar tb2;
        private System.Windows.Forms.TrackBar tb1;
        private System.Windows.Forms.NumericUpDown ns5;
        private System.Windows.Forms.NumericUpDown ns4;
        private System.Windows.Forms.NumericUpDown ns3;
        private System.Windows.Forms.NumericUpDown ns2;
        private System.Windows.Forms.NumericUpDown ns1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblPWM;
        private System.Windows.Forms.ProgressBar prgPWM;
        private System.Windows.Forms.NotifyIcon ti1;
        private System.Windows.Forms.Label lblPWM5;
        private System.Windows.Forms.Label lblPWM4;
        private System.Windows.Forms.Label lblPWM3;
        private System.Windows.Forms.Label lblPWM2;
        private System.Windows.Forms.Label lblPWM1;
        private System.Windows.Forms.ContextMenuStrip cms1;
        private System.Windows.Forms.CheckBox chkStartMinimized;
        private System.Windows.Forms.Button btnSaveFanSpeedToEEprom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel pnlTempColor;
        private System.Windows.Forms.Button btnStartTempMode;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel pnlHotColor;
        private System.Windows.Forms.Panel pnlColdColor;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown nsHot;
        private System.Windows.Forms.NumericUpDown nsCold;
    }
}