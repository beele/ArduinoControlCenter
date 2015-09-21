using System;
using System.Drawing;
using System.Windows.Forms;
using ArduinoControlCenter.Controller;
using TinyMessenger;
using ArduinoControlCenter.Model;
using ArduinoControlCenter.Utils.Messenger;

namespace ArduinoControlCenter.Views
{
    public partial class MainForm : Form
    {
        public ApplicationController appController;
        public ColorController colorController;

        public TinyMessengerHub messageHub;
        public ColorModel colorModel;
        public HardwareModel hardwareModel;
        public SettingsModel settingsModel;

        public ColorPickerDialog colorPickerDialog;

        public MainForm()
        {
            InitializeComponent();
        }

        //Form load: instanciate all new required classes
        private void MainForm_Load(object sender, EventArgs e)
        {
            initGUI();
        }

        //Init the GUI, set all the parts to show the correct data.
        private void initGUI()
        {
            //Color picker dialog
            colorPickerDialog = new ColorPickerDialog();

            //IO port elements
            String[] comms = System.IO.Ports.SerialPort.GetPortNames();
            cmbComms.DataSource = comms;
            cmbComms.SelectedIndex = comms.Length - 1;

            //Trackbars
            tbSmoothScreen.Minimum = 1;
            tbSmoothScreen.Maximum = 500;

            tbSmoothFade.Minimum = 1;
            tbSmoothFade.Maximum = 30;

            appController.onGuiFormLoaded();
        }

        public void init(ColorModel colorModel, HardwareModel hardwareModel, TinyMessengerHub messageHub)
        {
            this.colorModel = colorModel;
            this.hardwareModel = hardwareModel;
            this.messageHub = messageHub;

            messageHub.Subscribe<ColorModelMessage>((m) => colorModelUpdated(m.Content));
            messageHub.Subscribe<HardwareModelMessage>((m) => { this.Invoke(new MethodInvoker(hardwareModelUpdated)); });
            messageHub.Subscribe<SettingsModelMessage>((m) => { this.Invoke(new MethodInvoker(settingsModelUpdated)); });
        }

        private void colorModelUpdated(COLOR_FIELDS val)
        {
            switch (val)
            {
                case COLOR_FIELDS.COLOR:
                    this.Invoke(new MethodInvoker(colorChanged));
                    break;
                case COLOR_FIELDS.FPS:
                    this.Invoke(new MethodInvoker(fpsChanged));
                    break;
                case COLOR_FIELDS.STATUS:
                    this.Invoke(new MethodInvoker(updateStatus));
                    break;
            }
        }

        private void hardwareModelUpdated()
        {
            lblCore1.Text = (hardwareModel.sensors[0].Value + "°C");
            lblCore2.Text = (hardwareModel.sensors[1].Value + "°C");
            lblCore3.Text = (hardwareModel.sensors[2].Value + "°C");
            lblCore4.Text = (hardwareModel.sensors[3].Value + "°C");

            prgCore1.Value = (int)hardwareModel.sensors[0].Value;
            prgCore2.Value = (int)hardwareModel.sensors[1].Value;
            prgCore3.Value = (int)hardwareModel.sensors[2].Value;
            prgCore4.Value = (int)hardwareModel.sensors[3].Value;

            lblPWM.Text = hardwareModel.calculatedSpeed + "%";
            prgPWM.Value = hardwareModel.calculatedSpeed;

            lblPWM1.Text = hardwareModel.dataPoints[0].speed + "%";
            lblPWM2.Text = hardwareModel.dataPoints[1].speed + "%";
            lblPWM3.Text = hardwareModel.dataPoints[2].speed + "%";
            lblPWM4.Text = hardwareModel.dataPoints[3].speed + "%";
            lblPWM5.Text = hardwareModel.dataPoints[4].speed + "%";

            tb1.Value = hardwareModel.dataPoints[0].speed;
            tb2.Value = hardwareModel.dataPoints[1].speed;
            tb3.Value = hardwareModel.dataPoints[2].speed;
            tb4.Value = hardwareModel.dataPoints[3].speed;
            tb5.Value = hardwareModel.dataPoints[4].speed;

            ns1.Value = hardwareModel.dataPoints[0].temperature;
            ns2.Value = hardwareModel.dataPoints[1].temperature;
            ns3.Value = hardwareModel.dataPoints[2].temperature;
            ns4.Value = hardwareModel.dataPoints[3].temperature;
            ns5.Value = hardwareModel.dataPoints[4].temperature;

            chkQuietMode.Checked = hardwareModel.quietModeEnabled;
            nsQuietModeSpeed.Value = hardwareModel.quietModeSpeed;
        }

        private void settingsModelUpdated()
        {
            chkReconnectCom.Checked = settingsModel.autoReconnect;
            chkStartMinimized.Checked = settingsModel.startMinimized;
        }

        //When the FPS has changed!
        public void fpsChanged()
        {
            lblFPS.Text = "FPS: " + colorModel.FPS + "";
        }

        //When the color has changed!
        public void colorChanged()
        {
            switch (colorController.mode)
            {
                case ColorModel.COLORMODES.manual:
                    pnlColorManual.BackColor = colorModel.color;
                    break;
                case ColorModel.COLORMODES.screen:
                    pnlColorAuto.BackColor = colorModel.color;
                    break;
                case ColorModel.COLORMODES.fade:
                    pnlFadeColor.BackColor = colorModel.color;
                    break;
                case ColorModel.COLORMODES.temp:
                    pnlTempColor.BackColor = colorModel.color;
                    break;
            }
        }

        //Updates the statusbar text
        public void updateStatus()
        {
            stbrConnection.Text = colorModel.status;
            if (colorModel.status.Contains("ERROR"))
            {
                btnCommAction.Text = "Connect";
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ti1.Visible = true;
                ti1.ShowBalloonTip(500);

                //This line causes a stack overflow error in the windows forms dll WTF!
                //ShowInTaskbar = false;
            }
            //The same line here does not cause a stack overflow error! Double WTF!!
            ShowInTaskbar = false;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            ti1.Visible = false;

            //Update gui
            hardwareModelUpdated();
            settingsModelUpdated();
        }

        //Properly close the connection when the form is closed!
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            appController.dispose();
            ti1.Dispose();
        }

        #region --== Manual mode ==--
        /******************************************************
        **************MANUAL model SECTION******************
        *******************************************************/
        private void pnlColorManual_Click(object sender, EventArgs e)
        {
            setupColorPickingDialog("Select the static color", manualModeColorPicker_FormClosing);
        }

        private void manualModeColorPicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Color c = HandleColorPickerDialogResult(e, manualModeColorPicker_FormClosing);
            //Stop other modes and apply the selected color.
            disableOtherMode();
            //Save selected start color!
            pnlColorManual.BackColor = c;
            colorController.setSelectedColor(c, false);
        }

        private void btnSaveColorToEEprom_Click(object sender, EventArgs e)
        {
            disableOtherMode();
            DialogResult result;
            result = MessageBox.Show(this, "Are you sure you want to write the selected color to the arduino EEprom memory?", "Write to EEprom",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                colorController.setSelectedColor(colorModel.color, false);
            }
            if (result == DialogResult.Yes)
            {
                colorController.setSelectedColor(colorModel.color, true);
            }
        }

        private void disableOtherMode()
        {
            if (colorController.mode == ColorModel.COLORMODES.screen)
            {
                colorController.mode = ColorModel.COLORMODES.manual;
                btnStart.Text = "Start";
                lblFPS.Text = "FPS: -";

                btnStartFade.Text = "Start";
                tbSmoothFade.Enabled = true;
            }
        }
        #endregion

        #region --== Screen mode ==--
        /******************************************************
        *************CAPTURE model SECTION******************
        *******************************************************/
        //Enhance checkbox changed
        private void chkEnhance_CheckedChanged_1(object sender, EventArgs e)
        {
            colorModel.doEnhancementOfColor = chkEnhance.Checked;
        }

        //Smoothing changed
        private void tbSmooth_Scroll_1(object sender, EventArgs e)
        {
            colorModel.delay = tbSmoothScreen.Value;
        }

        //Capture average color clicked
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                //Do auto color detection
                colorController.mode = ColorModel.COLORMODES.screen;
                btnStart.Text = "Stop";
            }
            else
            {
                //set GUI for manual mode
                colorController.mode = ColorModel.COLORMODES.manual;
                lblFPS.Text = "FPS: -";
                btnStart.Text = "Start";
            }
        }
        #endregion

        #region --== Fade mode ==--
        /******************************************************
        *****************FADE model SECTION********************
        *******************************************************/
        private void btnStartFade_Click(object sender, EventArgs e)
        {
            if (btnStartFade.Text == "Start")
            {
                //Do auto color detection
                colorController.mode = ColorModel.COLORMODES.fade;
                btnStartFade.Text = "Stop";
                tbSmoothFade.Enabled = false;
                pnlStartColor.Enabled = false;
                pnlStopColor.Enabled = false;
            }
            else
            {
                //set GUI for manual mode
                colorController.mode = ColorModel.COLORMODES.manual;
                btnStartFade.Text = "Start";
                tbSmoothFade.Enabled = true;
                pnlStartColor.Enabled = true;
                pnlStopColor.Enabled = true;
            }
        }

        private void tbSmoothFade_Scroll(object sender, EventArgs e)
        {
            colorModel.fadeDuration = tbSmoothFade.Value;
        }

        private void pnlStartColor_Click(object sender, EventArgs e)
        {
            setupColorPickingDialog("Select the start color", startFadeColorPicker_FormClosing);
        }

        private void startFadeColorPicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Color c = HandleColorPickerDialogResult(e, startFadeColorPicker_FormClosing);
            pnlStartColor.BackColor = c;
            colorModel.fadeStartColor = c;
        }

        private void pnlStopColor_Click(object sender, EventArgs e)
        {
            setupColorPickingDialog("Select the stop color", stopFadeColorPicker_FormClosing);
        }

        private void stopFadeColorPicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Color c = HandleColorPickerDialogResult(e, stopFadeColorPicker_FormClosing);
            pnlStopColor.BackColor = c;
            colorModel.fadeStopColor = c;
        }
        #endregion

        #region --== Temp mode ==--
        /******************************************************
        *************TEMPERATURE model SECTION*****************
        *******************************************************/
        private void btnStartTempMode_Click(object sender, EventArgs e)
        {
            if (btnStartTempMode.Text == "Start")
            {
                //Do temperature color detection
                colorController.mode = ColorModel.COLORMODES.temp;
                btnStartTempMode.Text = "Stop";
            }
            else
            {
                //set GUI for manual mode
                colorController.mode = ColorModel.COLORMODES.manual;
                btnStartTempMode.Text = "Start";
            }
        }

        private void pnlColdColor_Click(object sender, EventArgs e)
        {
            setupColorPickingDialog("Select the cold color", tempModeColdColorPicker_FormClosing);
        }

        private void tempModeColdColorPicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Color c = HandleColorPickerDialogResult(e, tempModeColdColorPicker_FormClosing);
            pnlColdColor.BackColor = c;
            colorModel.coldTempColor = c;
        }

        private void pnlHotColor_Click(object sender, EventArgs e)
        {
            setupColorPickingDialog("Select the hot color", tempModeHotColorPicker_FormClosing);
        }

        private void tempModeHotColorPicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Color c = HandleColorPickerDialogResult(e, tempModeHotColorPicker_FormClosing);
            pnlHotColor.BackColor = c;
            colorModel.hotTempColor = c;
        }

        private void nsCold_ValueChanged(object sender, EventArgs e)
        {
            //TODO: Catch edge cases
            colorModel.coldTemp = (int)nsCold.Value;
            if(nsHot.Value < nsCold.Value)
            {
                nsHot.Value = nsCold.Value + 1;
            }
        }

        private void nsHot_ValueChanged(object sender, EventArgs e)
        {
            //TODO: Catch edge cases
            colorModel.hotTemp = (int)nsHot.Value;
            if (nsHot.Value < nsCold.Value)
            {
                nsHot.Value = nsCold.Value + 1;
            } else if(nsHot.Value == nsCold.Value)
            {
                nsCold.Value -= 1;
            }
        }
        #endregion

        #region --== Fan control ==--
        /******************************************************
        *************FAN CONTROL model SECTION*****************
        *******************************************************/
        private void tb1_ValueChanged(object sender, EventArgs e)
        {
            hardwareModel.dataPoints[0].speed = tb1.Value;
            lblPWM1.Text = hardwareModel.dataPoints[0].speed + "%";
        }

        private void tb2_ValueChanged(object sender, EventArgs e)
        {
            hardwareModel.dataPoints[1].speed = tb2.Value;
            lblPWM2.Text = hardwareModel.dataPoints[1].speed + "%";
        }

        private void tb3_ValueChanged(object sender, EventArgs e)
        {
            hardwareModel.dataPoints[2].speed = tb3.Value;
            lblPWM3.Text = hardwareModel.dataPoints[2].speed + "%";
        }

        private void tb4_ValueChanged(object sender, EventArgs e)
        {
            hardwareModel.dataPoints[3].speed = tb4.Value;
            lblPWM4.Text = hardwareModel.dataPoints[3].speed + "%";
        }

        private void tb5_ValueChanged(object sender, EventArgs e)
        {
            hardwareModel.dataPoints[4].speed = tb5.Value;
            lblPWM5.Text = hardwareModel.dataPoints[4].speed + "%";
        }

        private void ns1_ValueChanged(object sender, EventArgs e)
        {
            hardwareModel.dataPoints[0].temperature = (int)ns1.Value;
        }

        private void ns2_ValueChanged(object sender, EventArgs e)
        {
            hardwareModel.dataPoints[1].temperature = (int)ns2.Value;
        }

        private void ns3_ValueChanged(object sender, EventArgs e)
        {
            hardwareModel.dataPoints[2].temperature = (int)ns3.Value;
        }

        private void ns4_ValueChanged(object sender, EventArgs e)
        {
            hardwareModel.dataPoints[3].temperature = (int)ns4.Value;
        }

        private void ns5_ValueChanged(object sender, EventArgs e)
        {
            hardwareModel.dataPoints[4].temperature = (int)ns5.Value;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            hardwareModel.quietModeEnabled = chkQuietMode.Checked;
        }

        private void nsQuietModeSpeed_ValueChanged(object sender, EventArgs e)
        {
            hardwareModel.quietModeSpeed = (int)nsQuietModeSpeed.Value;
        }
        #endregion

        #region --== Arduino & settings section ==--
        /******************************************************
        ***********ARDUINO & SETTINGS model SECTION************
        *******************************************************/
        //Com list refresh clicked
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            String[] comms = System.IO.Ports.SerialPort.GetPortNames();
            cmbComms.DataSource = comms;
            cmbComms.SelectedIndex = comms.Length - 1;
        }

        //Com action clicked (conntect/disconnect comm port)
        private void btnCommAction_Click(object sender, EventArgs e)
        {
            if (btnCommAction.Text == "Connect")
            {
                appController.openComm();
            }
            else
            {
                appController.closeComm();
            }
        }

        public void setComLabels()
        {
            if (btnCommAction.Text == "Connect")
            {
                btnCommAction.Text = "Disconnect";
            }
            else
            {
                btnCommAction.Text = "Connect";
            }
        }

        private void chkReconnectCom_CheckedChanged(object sender, EventArgs e)
        {
            appController.setAutoReconnect(chkReconnectCom.Checked);
        }

        private void chkStartMinimized_CheckedChanged(object sender, EventArgs e)
        {
            appController.setStartMinimized(chkStartMinimized.Checked);
        }

        #endregion

        //Utils:
        private void setupColorPickingDialog(String title, FormClosingEventHandler handler)
        {
            this.Enabled = false;
            colorPickerDialog.Text = title;
            colorPickerDialog.FormClosing += handler;
            colorPickerDialog.Show();
        }

        private Color HandleColorPickerDialogResult(FormClosingEventArgs e, FormClosingEventHandler handler)
        {
            //Clean up the color picker dialog.
            this.Enabled = true;
            colorPickerDialog.FormClosing -= handler;
            colorPickerDialog.Hide();
            e.Cancel = true;

            //Return the selected color.
            return colorPickerDialog.selectedColor;
        }
    }
}
