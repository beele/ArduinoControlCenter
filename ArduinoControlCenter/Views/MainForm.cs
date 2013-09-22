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
        public ColorController controller;

        public TinyMessengerHub messageHub;
        public ColorModel colorModel;
        public HardwareModel temperatureModel;

        public ColorPickerDialog startPicker;
        public ColorPickerDialog stopPicker;
        
        public MainForm()
        {
            InitializeComponent();
        }

        public void init(ColorModel colorModel, HardwareModel temperatureModel, TinyMessengerHub messageHub) 
        {
            this.colorModel = colorModel;
            this.temperatureModel = temperatureModel;
            this.messageHub = messageHub;

            messageHub.Subscribe<ColorModelMessage>((m) => colorModelUpdated(m.Content));
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

        //Form load: instanciate all new required classes
        private void MainForm_Load(object sender, EventArgs e)
        {
            initGUI();
        }

        //Init the GUI, set all the parts to show the correct data.
        private void initGUI()
        {
            //Color wheel
            colorWheel.ColorChanged += new EventHandler(colorWheel_ColorChanged);
            colorWheel.nudBrightness.Value = 255;
            colorWheel_ColorChanged(null, null);

            //Color picker dialogs
            startPicker = new ColorPickerDialog();
            startPicker.Text = "Pick the start color";
            startPicker.FormClosing += new FormClosingEventHandler(colorPicker_FormClosing);

            stopPicker = new ColorPickerDialog();
            stopPicker.Text = "Pick the stop color";
            stopPicker.FormClosing += new FormClosingEventHandler(stopPicker_FormClosing);

            //IO port elements
            String[] comms = System.IO.Ports.SerialPort.GetPortNames();
            cmbComms.DataSource = comms;
            cmbComms.SelectedIndex = comms.Length - 1;

            int[] pinNumbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int[] pinNumbers2 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int[] pinNumbers3 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            cmbRed.DataSource = pinNumbers;
            cmbGreen.DataSource = pinNumbers2;
            cmbBlue.DataSource = pinNumbers3;

            cmbRed.SelectedIndex = -1;
            cmbGreen.SelectedIndex = -1;
            cmbBlue.SelectedIndex = -1;

            cmbRed.Text = "pin";
            cmbGreen.Text = "pin";
            cmbBlue.Text = "pin";

            //Trackbars
            tbSmoothScreen.Minimum = 1;
            tbSmoothScreen.Maximum = 500;

            tbSmoothFade.Minimum = 1;
            tbSmoothFade.Maximum = 30;
        }

        //When the FPS has changed!
        public void fpsChanged()
        {
            lblFPS.Text = "FPS: " + colorModel.FPS + "";
        }

        //When the color has changed!
        public void colorChanged()
        {   
            switch (controller.mode)
	        {
                case ColorModel.COLORMODES.screen:
                    pnlColorAuto.BackColor = colorModel.color;
                break;
                case ColorModel.COLORMODES.fade:
                    pnlColorFade.BackColor = colorModel.color;
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

        //Properly close the connection when the form is closed!
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.dispose();
        }

        #region --== Manual mode ==--
        /******************************************************
        **************MANUAL model SECTION******************
        *******************************************************/
        //Color changed in colorwheel
        private void colorWheel_ColorChanged(object sender, EventArgs e)
        {
            pnlColorManual.BackColor = colorWheel.SelectedColor;
        }

        //Apply clicked to aplly the selected color from the colorwheel
        private void btnManual_Click_1(object sender, EventArgs e)
        {
            disableOtherMode();
            controller.setSelectedColor(colorWheel.SelectedColor,false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            disableOtherMode();
            DialogResult result;
            result = MessageBox.Show(this, "Are you sure you want to write the selected color to the arduino EEprom memory?", "Write to EEprom", 
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                controller.setSelectedColor(colorWheel.SelectedColor, false);
            }
            if (result == DialogResult.Yes)
            {
                controller.setSelectedColor(colorWheel.SelectedColor, true);
            }
        }

        private void disableOtherMode()
        {
            if (controller.mode == ColorModel.COLORMODES.screen)
            {
                controller.mode = ColorModel.COLORMODES.manual;
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
            controller.setEnhanceMode(chkEnhance.Checked);
        }

        //Smoothing changed
        private void tbSmooth_Scroll_1(object sender, EventArgs e)
        {
            controller.setSampleDelay(tbSmoothScreen.Value);
        }

        //Capture average color clicked
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                //Do auto color detection
                controller.mode = ColorModel.COLORMODES.screen;
                btnStart.Text = "Stop";
            }
            else
            {
                //set GUI for manual mode
                controller.mode = ColorModel.COLORMODES.manual;
                lblFPS.Text = "FPS: -";
                btnStart.Text = "Start";
            }
        }
        #endregion

        #region --== Fade mode ==--
        /******************************************************
        *****************FADE model SECTION********************
        *******************************************************/
        private void button2_Click(object sender, EventArgs e)
        {
            if (btnStartFade.Text == "Start")
            {
                //Do auto color detection
                controller.mode = ColorModel.COLORMODES.fade;
                btnStartFade.Text = "Stop";
                tbSmoothFade.Enabled = false;
                pnlStartColor.Enabled = false;
                pnlStopColor.Enabled = false;
            }
            else
            {
                //set GUI for manual mode
                controller.mode = ColorModel.COLORMODES.manual;
                btnStartFade.Text = "Start";
                tbSmoothFade.Enabled = true;
                pnlStartColor.Enabled = true;
                pnlStopColor.Enabled = true;
            }
        }

        private void tbSmoothFade_Scroll(object sender, EventArgs e)
        {
            controller.setFadeDuration(tbSmoothFade.Value);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            startPicker.Show();
        }

        private void colorPicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save selected start color!
            this.Enabled = true;
            ColorPickerDialog p = (ColorPickerDialog)sender;

            pnlStartColor.BackColor = p.selectedColor;
            controller.setFadeStartColor(p.selectedColor);

            e.Cancel = true;
            p.Hide();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            stopPicker.Show();
        }

        private void stopPicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save selected stop color!
            this.Enabled = true;
            ColorPickerDialog p = (ColorPickerDialog)sender;

            pnlStopColor.BackColor = p.selectedColor;
            controller.setFadeStopColor(p.selectedColor);

            e.Cancel = true;
            p.Hide();
        }
        #endregion

        #region --== Arduino section ==--
        /******************************************************
        *************ARDUINO model SECTION******************
        *******************************************************/
        //Comm list refresh clicked
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            String[] comms = System.IO.Ports.SerialPort.GetPortNames();
            cmbComms.DataSource = comms;
            cmbComms.SelectedIndex = comms.Length - 1;
        }

        //Comm action clicked (conntect/disconnect comm port)
        private void btnCommAction_Click(object sender, EventArgs e)
        {
            if (btnCommAction.Text == "Connect")
            {
                appController.openComm();
                btnCommAction.Text = "Disconnect";
            }
            else
            {
                appController.closeComm();
                btnCommAction.Text = "Connect";
            }
        }

        //Generate arduino code button clicked
        private void generateCode_Click(object sender, EventArgs e)
        {
            if (cmbRed.SelectedIndex == -1 || cmbGreen.SelectedIndex == -1 || cmbBlue.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter a value for all the pins!", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cmbRed.SelectedIndex == cmbGreen.SelectedIndex || cmbRed.SelectedIndex == cmbBlue.SelectedIndex || cmbGreen.SelectedIndex == cmbBlue.SelectedIndex)
            {
                MessageBox.Show("Duplicate pin values are not allowed!", "Duplicates", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                GeneratedCodeForm codeForm = new GeneratedCodeForm();
                codeForm.red = cmbRed.SelectedIndex;
                codeForm.green = cmbGreen.SelectedIndex;
                codeForm.blue = cmbBlue.SelectedIndex;
                codeForm.Show();
            }
        }

        #endregion
    }
}
