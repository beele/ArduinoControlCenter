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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBlue = new System.Windows.Forms.ComboBox();
            this.cmbGreen = new System.Windows.Forms.ComboBox();
            this.cmbRed = new System.Windows.Forms.ComboBox();
            this.cmbComms = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCommAction = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabcon = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.lblCurrentManual = new System.Windows.Forms.Label();
            this.colorWheel = new Components.ColorWheel.ColorChooser1();
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
            this.statusStrip1.SuspendLayout();
            this.gbmodel.SuspendLayout();
            this.tabcon.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSmoothScreen)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSmoothFade)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbrConnection});
            this.statusStrip1.Location = new System.Drawing.Point(0, 372);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(512, 22);
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
            this.gbmodel.Controls.Add(this.btnRefresh);
            this.gbmodel.Controls.Add(this.label3);
            this.gbmodel.Controls.Add(this.label2);
            this.gbmodel.Controls.Add(this.label1);
            this.gbmodel.Controls.Add(this.cmbBlue);
            this.gbmodel.Controls.Add(this.cmbGreen);
            this.gbmodel.Controls.Add(this.cmbRed);
            this.gbmodel.Controls.Add(this.cmbComms);
            this.gbmodel.Controls.Add(this.button1);
            this.gbmodel.Controls.Add(this.btnCommAction);
            this.gbmodel.Controls.Add(this.label4);
            this.gbmodel.Location = new System.Drawing.Point(291, 12);
            this.gbmodel.Name = "gbmodel";
            this.gbmodel.Size = new System.Drawing.Size(208, 345);
            this.gbmodel.TabIndex = 9;
            this.gbmodel.TabStop = false;
            this.gbmodel.Text = "Arduino settings";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(139, 89);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Blue PWM pin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Green PWM pin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Red PWM pin:";
            // 
            // cmbBlue
            // 
            this.cmbBlue.FormattingEnabled = true;
            this.cmbBlue.Location = new System.Drawing.Point(98, 280);
            this.cmbBlue.Name = "cmbBlue";
            this.cmbBlue.Size = new System.Drawing.Size(55, 21);
            this.cmbBlue.TabIndex = 14;
            this.cmbBlue.Text = "pin";
            // 
            // cmbGreen
            // 
            this.cmbGreen.FormattingEnabled = true;
            this.cmbGreen.Location = new System.Drawing.Point(98, 253);
            this.cmbGreen.Name = "cmbGreen";
            this.cmbGreen.Size = new System.Drawing.Size(55, 21);
            this.cmbGreen.TabIndex = 13;
            this.cmbGreen.Text = "pin";
            // 
            // cmbRed
            // 
            this.cmbRed.FormattingEnabled = true;
            this.cmbRed.Location = new System.Drawing.Point(98, 226);
            this.cmbRed.Name = "cmbRed";
            this.cmbRed.Size = new System.Drawing.Size(55, 21);
            this.cmbRed.TabIndex = 12;
            this.cmbRed.Text = "pin";
            // 
            // cmbComms
            // 
            this.cmbComms.FormattingEnabled = true;
            this.cmbComms.Location = new System.Drawing.Point(11, 91);
            this.cmbComms.Name = "cmbComms";
            this.cmbComms.Size = new System.Drawing.Size(121, 21);
            this.cmbComms.TabIndex = 11;
            this.cmbComms.Text = "Select comm port";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Generate arduino code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.generateCode_Click);
            // 
            // btnCommAction
            // 
            this.btnCommAction.Location = new System.Drawing.Point(9, 118);
            this.btnCommAction.Name = "btnCommAction";
            this.btnCommAction.Size = new System.Drawing.Size(154, 23);
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
            this.tabcon.Location = new System.Drawing.Point(12, 12);
            this.tabcon.Name = "tabcon";
            this.tabcon.SelectedIndex = 0;
            this.tabcon.Size = new System.Drawing.Size(273, 345);
            this.tabcon.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnManual);
            this.tabPage1.Controls.Add(this.lblCurrentManual);
            this.tabPage1.Controls.Add(this.colorWheel);
            this.tabPage1.Controls.Add(this.pnlColorManual);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(265, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manual mode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(174, 261);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnManual
            // 
            this.btnManual.Location = new System.Drawing.Point(174, 287);
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
            // colorWheel
            // 
            this.colorWheel.Location = new System.Drawing.Point(6, 6);
            this.colorWheel.Name = "colorWheel";
            this.colorWheel.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colorWheel.Size = new System.Drawing.Size(243, 190);
            this.colorWheel.TabIndex = 11;
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
            this.tabPage2.Size = new System.Drawing.Size(265, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Screen mode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(223, 151);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(26, 13);
            this.lblMax.TabIndex = 22;
            this.lblMax.Text = "max";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(12, 151);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(23, 13);
            this.lblMin.TabIndex = 21;
            this.lblMin.Text = "min";
            // 
            // lblSmooth
            // 
            this.lblSmooth.AutoSize = true;
            this.lblSmooth.Location = new System.Drawing.Point(11, 105);
            this.lblSmooth.Name = "lblSmooth";
            this.lblSmooth.Size = new System.Drawing.Size(76, 13);
            this.lblSmooth.TabIndex = 20;
            this.lblSmooth.Text = "Capture speed";
            // 
            // tbSmoothScreen
            // 
            this.tbSmoothScreen.LargeChange = 50;
            this.tbSmoothScreen.Location = new System.Drawing.Point(11, 124);
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
            this.lblAutoInfo.AutoSize = true;
            this.lblAutoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoInfo.Location = new System.Drawing.Point(6, 10);
            this.lblAutoInfo.Name = "lblAutoInfo";
            this.lblAutoInfo.Size = new System.Drawing.Size(223, 39);
            this.lblAutoInfo.TabIndex = 15;
            this.lblAutoInfo.Text = "Set the RGB color to the avrage screen color.\r\n\r\nBelow are some options you can s" +
    "et:";
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
            this.btnStart.Location = new System.Drawing.Point(174, 287);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tabPage3
            // 
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
            this.tabPage3.Size = new System.Drawing.Size(265, 319);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fade mode";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 52);
            this.label8.TabIndex = 25;
            this.label8.Text = "Set the color to follow a pattern that you have \r\ndefined.\r\n\r\nBelow are some opti" +
    "ons to define the pattern:";
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
            this.btnStartFade.Location = new System.Drawing.Point(174, 287);
            this.btnStartFade.Name = "btnStartFade";
            this.btnStartFade.Size = new System.Drawing.Size(75, 23);
            this.btnStartFade.TabIndex = 23;
            this.btnStartFade.Text = "Start";
            this.btnStartFade.UseVisualStyleBackColor = true;
            this.btnStartFade.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 394);
            this.Controls.Add(this.tabcon);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox gbmodel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCommAction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbBlue;
        private System.Windows.Forms.ComboBox cmbGreen;
        private System.Windows.Forms.ComboBox cmbRed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
    }
}