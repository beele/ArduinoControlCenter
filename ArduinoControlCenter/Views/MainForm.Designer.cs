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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stbrConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbmodel = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbComms = new System.Windows.Forms.ComboBox();
            this.btnCommAction = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabcon = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.lblCurrentManual = new System.Windows.Forms.Label();
            this.pnlColorManual = new System.Windows.Forms.Panel();
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
            this.pnlColorFade = new System.Windows.Forms.Panel();
            this.btnStartFade = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
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
            this.colorWheel = new Components.ColorWheel.ColorChooser1();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.prgPWM = new System.Windows.Forms.ProgressBar();
            this.lblPWM = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.gbmodel.SuspendLayout();
            this.tabcon.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSmoothScreen)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSmoothFade)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbrConnection});
            this.statusStrip1.Location = new System.Drawing.Point(0, 412);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stbrConnection
            // 
            this.stbrConnection.Name = "stbrConnection";
            this.stbrConnection.Size = new System.Drawing.Size(86, 17);
            this.stbrConnection.Text = "Not connected";
            // 
            // gbmodel
            // 
            this.gbmodel.Controls.Add(this.checkBox1);
            this.gbmodel.Controls.Add(this.btnRefresh);
            this.gbmodel.Controls.Add(this.cmbComms);
            this.gbmodel.Controls.Add(this.btnCommAction);
            this.gbmodel.Controls.Add(this.label4);
            this.gbmodel.Controls.Add(this.shapeContainer2);
            this.gbmodel.Location = new System.Drawing.Point(767, 12);
            this.gbmodel.Name = "gbmodel";
            this.gbmodel.Size = new System.Drawing.Size(208, 385);
            this.gbmodel.TabIndex = 9;
            this.gbmodel.TabStop = false;
            this.gbmodel.Text = "Arduino Control";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 131);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Auto-reconnect";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(178, 89);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbComms
            // 
            this.cmbComms.FormattingEnabled = true;
            this.cmbComms.Location = new System.Drawing.Point(11, 91);
            this.cmbComms.Name = "cmbComms";
            this.cmbComms.Size = new System.Drawing.Size(161, 21);
            this.cmbComms.TabIndex = 11;
            this.cmbComms.Text = "Select com port";
            // 
            // btnCommAction
            // 
            this.btnCommAction.Location = new System.Drawing.Point(9, 173);
            this.btnCommAction.Name = "btnCommAction";
            this.btnCommAction.Size = new System.Drawing.Size(193, 23);
            this.btnCommAction.TabIndex = 9;
            this.btnCommAction.Text = "Connect";
            this.btnCommAction.UseVisualStyleBackColor = true;
            this.btnCommAction.Click += new System.EventHandler(this.btnCommAction_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Serial port communication options.\r\n\r\nBelow are some options you can set:\r\n";
            // 
            // tabcon
            // 
            this.tabcon.Controls.Add(this.tabPage1);
            this.tabcon.Controls.Add(this.tabPage2);
            this.tabcon.Controls.Add(this.tabPage3);
            this.tabcon.Controls.Add(this.tabPage4);
            this.tabcon.Location = new System.Drawing.Point(13, 30);
            this.tabcon.Name = "tabcon";
            this.tabcon.SelectedIndex = 0;
            this.tabcon.Size = new System.Drawing.Size(355, 345);
            this.tabcon.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnManual);
            this.tabPage1.Controls.Add(this.lblCurrentManual);
            this.tabPage1.Controls.Add(this.colorWheel);
            this.tabPage1.Controls.Add(this.pnlColorManual);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(347, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manual mode";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(332, 39);
            this.label12.TabIndex = 16;
            this.label12.Text = "Set the RGB color to a static color. This mode is active by default!\r\n\r\nClick sav" +
    "e to write the color to the eeprom memory.";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(179, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnManual
            // 
            this.btnManual.Location = new System.Drawing.Point(263, 287);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(75, 23);
            this.btnManual.TabIndex = 13;
            this.btnManual.Text = "Apply";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click_1);
            // 
            // lblCurrentManual
            // 
            this.lblCurrentManual.AutoSize = true;
            this.lblCurrentManual.Location = new System.Drawing.Point(6, 218);
            this.lblCurrentManual.Name = "lblCurrentManual";
            this.lblCurrentManual.Size = new System.Drawing.Size(67, 13);
            this.lblCurrentManual.TabIndex = 14;
            this.lblCurrentManual.Text = "Current color";
            // 
            // pnlColorManual
            // 
            this.pnlColorManual.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlColorManual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColorManual.Location = new System.Drawing.Point(6, 237);
            this.pnlColorManual.Name = "pnlColorManual";
            this.pnlColorManual.Size = new System.Drawing.Size(73, 73);
            this.pnlColorManual.TabIndex = 12;
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(347, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Screen mode";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(223, 190);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(26, 13);
            this.lblMax.TabIndex = 22;
            this.lblMax.Text = "max";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(12, 190);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(23, 13);
            this.lblMin.TabIndex = 21;
            this.lblMin.Text = "min";
            // 
            // lblSmooth
            // 
            this.lblSmooth.AutoSize = true;
            this.lblSmooth.Location = new System.Drawing.Point(11, 144);
            this.lblSmooth.Name = "lblSmooth";
            this.lblSmooth.Size = new System.Drawing.Size(76, 13);
            this.lblSmooth.TabIndex = 20;
            this.lblSmooth.Text = "Capture speed";
            // 
            // tbSmoothScreen
            // 
            this.tbSmoothScreen.LargeChange = 50;
            this.tbSmoothScreen.Location = new System.Drawing.Point(11, 163);
            this.tbSmoothScreen.Name = "tbSmoothScreen";
            this.tbSmoothScreen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSmoothScreen.Size = new System.Drawing.Size(238, 45);
            this.tbSmoothScreen.SmallChange = 10;
            this.tbSmoothScreen.TabIndex = 19;
            this.tbSmoothScreen.TickFrequency = 100;
            this.tbSmoothScreen.Scroll += new System.EventHandler(this.tbSmooth_Scroll_1);
            // 
            // lblFPS
            // 
            this.lblFPS.AutoSize = true;
            this.lblFPS.Location = new System.Drawing.Point(81, 236);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(36, 13);
            this.lblFPS.TabIndex = 18;
            this.lblFPS.Text = "FPS: -";
            // 
            // chkEnhance
            // 
            this.chkEnhance.AutoSize = true;
            this.chkEnhance.Checked = true;
            this.chkEnhance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnhance.Location = new System.Drawing.Point(11, 71);
            this.chkEnhance.Name = "chkEnhance";
            this.chkEnhance.Size = new System.Drawing.Size(95, 17);
            this.chkEnhance.TabIndex = 17;
            this.chkEnhance.Text = "Enhance color";
            this.chkEnhance.UseVisualStyleBackColor = true;
            this.chkEnhance.CheckedChanged += new System.EventHandler(this.chkEnhance_CheckedChanged_1);
            // 
            // lblCurrentAuto
            // 
            this.lblCurrentAuto.AutoSize = true;
            this.lblCurrentAuto.Location = new System.Drawing.Point(6, 218);
            this.lblCurrentAuto.Name = "lblCurrentAuto";
            this.lblCurrentAuto.Size = new System.Drawing.Size(67, 13);
            this.lblCurrentAuto.TabIndex = 16;
            this.lblCurrentAuto.Text = "Current color";
            // 
            // lblAutoInfo
            // 
            this.lblAutoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoInfo.Location = new System.Drawing.Point(6, 10);
            this.lblAutoInfo.Name = "lblAutoInfo";
            this.lblAutoInfo.Size = new System.Drawing.Size(332, 39);
            this.lblAutoInfo.TabIndex = 15;
            this.lblAutoInfo.Text = "Set the RGB color to the average screen color.\r\n\r\nBelow are some options you can " +
    "set:";
            // 
            // pnlColorAuto
            // 
            this.pnlColorAuto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlColorAuto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColorAuto.Location = new System.Drawing.Point(6, 237);
            this.pnlColorAuto.Name = "pnlColorAuto";
            this.pnlColorAuto.Size = new System.Drawing.Size(73, 73);
            this.pnlColorAuto.TabIndex = 14;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(263, 287);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
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
            this.tabPage3.Controls.Add(this.pnlColorFade);
            this.tabPage3.Controls.Add(this.btnStartFade);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(347, 319);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fade mode";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "stop";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "start";
            // 
            // pnlStopColor
            // 
            this.pnlStopColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlStopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStopColor.Location = new System.Drawing.Point(71, 84);
            this.pnlStopColor.Name = "pnlStopColor";
            this.pnlStopColor.Size = new System.Drawing.Size(35, 35);
            this.pnlStopColor.TabIndex = 26;
            this.pnlStopColor.Click += new System.EventHandler(this.panel3_Click);
            // 
            // pnlStartColor
            // 
            this.pnlStartColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlStartColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStartColor.Location = new System.Drawing.Point(12, 84);
            this.pnlStartColor.Name = "pnlStartColor";
            this.pnlStartColor.Size = new System.Drawing.Size(35, 35);
            this.pnlStartColor.TabIndex = 25;
            this.pnlStartColor.Click += new System.EventHandler(this.panel2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Pattern duration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "30 sec";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "1 sec";
            // 
            // tbSmoothFade
            // 
            this.tbSmoothFade.LargeChange = 50;
            this.tbSmoothFade.Location = new System.Drawing.Point(11, 149);
            this.tbSmoothFade.Name = "tbSmoothFade";
            this.tbSmoothFade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSmoothFade.Size = new System.Drawing.Size(238, 45);
            this.tbSmoothFade.SmallChange = 10;
            this.tbSmoothFade.TabIndex = 27;
            this.tbSmoothFade.TickFrequency = 100;
            this.tbSmoothFade.Scroll += new System.EventHandler(this.tbSmoothFade_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Current color";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(332, 52);
            this.label8.TabIndex = 25;
            this.label8.Text = "Set the color to follow a pattern that you have defined.\r\n\r\nBelow are some option" +
    "s to define the pattern:";
            // 
            // pnlColorFade
            // 
            this.pnlColorFade.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlColorFade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColorFade.Location = new System.Drawing.Point(6, 237);
            this.pnlColorFade.Name = "pnlColorFade";
            this.pnlColorFade.Size = new System.Drawing.Size(73, 73);
            this.pnlColorFade.TabIndex = 24;
            // 
            // btnStartFade
            // 
            this.btnStartFade.Location = new System.Drawing.Point(263, 287);
            this.btnStartFade.Name = "btnStartFade";
            this.btnStartFade.Size = new System.Drawing.Size(75, 23);
            this.btnStartFade.TabIndex = 23;
            this.btnStartFade.Text = "Start";
            this.btnStartFade.UseVisualStyleBackColor = true;
            this.btnStartFade.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(347, 319);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Temperature mode";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabcon);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 385);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RGB Controls";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPWM);
            this.groupBox2.Controls.Add(this.prgPWM);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
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
            this.groupBox2.Controls.Add(this.shapeContainer1);
            this.groupBox2.Location = new System.Drawing.Point(398, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 385);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fan Control";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(169, 177);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "quiet pwm speed";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(17, 177);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Quiet mode";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(259, 174);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown1.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(260, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Control the fan speed via a custom temperature graph";
            // 
            // lblCore4
            // 
            this.lblCore4.AutoSize = true;
            this.lblCore4.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCore4.Location = new System.Drawing.Point(321, 144);
            this.lblCore4.Name = "lblCore4";
            this.lblCore4.Size = new System.Drawing.Size(28, 13);
            this.lblCore4.TabIndex = 11;
            this.lblCore4.Text = "# °C";
            // 
            // lblCore3
            // 
            this.lblCore3.AutoSize = true;
            this.lblCore3.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCore3.Location = new System.Drawing.Point(321, 115);
            this.lblCore3.Name = "lblCore3";
            this.lblCore3.Size = new System.Drawing.Size(28, 13);
            this.lblCore3.TabIndex = 10;
            this.lblCore3.Text = "# °C";
            // 
            // lblCore2
            // 
            this.lblCore2.AutoSize = true;
            this.lblCore2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCore2.Location = new System.Drawing.Point(321, 85);
            this.lblCore2.Name = "lblCore2";
            this.lblCore2.Size = new System.Drawing.Size(28, 13);
            this.lblCore2.TabIndex = 9;
            this.lblCore2.Text = "# °C";
            // 
            // lblCore1
            // 
            this.lblCore1.AutoSize = true;
            this.lblCore1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCore1.Location = new System.Drawing.Point(321, 57);
            this.lblCore1.Name = "lblCore1";
            this.lblCore1.Size = new System.Drawing.Size(28, 13);
            this.lblCore1.TabIndex = 8;
            this.lblCore1.Text = "# °C";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Core 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Core 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Core 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Core 1";
            // 
            // prgCore4
            // 
            this.prgCore4.Location = new System.Drawing.Point(55, 139);
            this.prgCore4.Name = "prgCore4";
            this.prgCore4.Size = new System.Drawing.Size(260, 23);
            this.prgCore4.TabIndex = 3;
            this.prgCore4.Value = 40;
            // 
            // prgCore3
            // 
            this.prgCore3.Location = new System.Drawing.Point(55, 110);
            this.prgCore3.Name = "prgCore3";
            this.prgCore3.Size = new System.Drawing.Size(260, 23);
            this.prgCore3.TabIndex = 2;
            this.prgCore3.Value = 40;
            // 
            // prgCore2
            // 
            this.prgCore2.Location = new System.Drawing.Point(55, 81);
            this.prgCore2.Name = "prgCore2";
            this.prgCore2.Size = new System.Drawing.Size(260, 23);
            this.prgCore2.TabIndex = 1;
            this.prgCore2.Value = 40;
            // 
            // prgCore1
            // 
            this.prgCore1.Location = new System.Drawing.Point(55, 52);
            this.prgCore1.Name = "prgCore1";
            this.prgCore1.Size = new System.Drawing.Size(260, 23);
            this.prgCore1.TabIndex = 0;
            this.prgCore1.Value = 40;
            // 
            // colorWheel
            // 
            this.colorWheel.Location = new System.Drawing.Point(94, 61);
            this.colorWheel.Name = "colorWheel";
            this.colorWheel.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colorWheel.Size = new System.Drawing.Size(243, 190);
            this.colorWheel.TabIndex = 11;
            this.colorWheel.Load += new System.EventHandler(this.colorWheel_Load);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(357, 366);
            this.shapeContainer1.TabIndex = 16;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 11;
            this.lineShape1.X2 = 344;
            this.lineShape1.Y1 = 196;
            this.lineShape1.Y2 = 196;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 12;
            this.lineShape2.X2 = 189;
            this.lineShape2.Y1 = 196;
            this.lineShape2.Y2 = 196;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(202, 366);
            this.shapeContainer2.TabIndex = 19;
            this.shapeContainer2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(188, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(188, 267);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(188, 232);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // prgPWM
            // 
            this.prgPWM.Location = new System.Drawing.Point(14, 339);
            this.prgPWM.Name = "prgPWM";
            this.prgPWM.Size = new System.Drawing.Size(264, 23);
            this.prgPWM.TabIndex = 23;
            // 
            // lblPWM
            // 
            this.lblPWM.Location = new System.Drawing.Point(284, 341);
            this.lblPWM.Name = "lblPWM";
            this.lblPWM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPWM.Size = new System.Drawing.Size(64, 19);
            this.lblPWM.TabIndex = 24;
            this.lblPWM.Text = "% PWM";
            this.lblPWM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 434);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbmodel);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Arduino Control Center";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbmodel.ResumeLayout(false);
            this.gbmodel.PerformLayout();
            this.tabcon.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSmoothScreen)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSmoothFade)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Label lblCurrentManual;
        private Components.ColorWheel.ColorChooser1 colorWheel;
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
        private System.Windows.Forms.Panel pnlColorFade;
        private System.Windows.Forms.Button btnStartFade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlStopColor;
        private System.Windows.Forms.Panel pnlStartColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox checkBox1;
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
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label18;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPWM;
        private System.Windows.Forms.ProgressBar prgPWM;
    }
}