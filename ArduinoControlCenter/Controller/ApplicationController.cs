using ArduinoControlCenter.Model;
using ArduinoControlCenter.Utils.Messenger;
using ArduinoControlCenter.Utils.SerialComm;
using ArduinoControlCenter.Utils.Settings;
using ArduinoControlCenter.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TinyMessenger;

namespace ArduinoControlCenter.Controller
{
    public class ApplicationController
    {
        private TinyMessengerHub _messageHub;

        private ColorController _colorController;
        private HardwareController _temperatureController;
        private SettingsModel _settingsModel;

        private ColorModel _colorModel;
        private HardwareModel _hardwareModel;
        private MainForm _gui;

        private Communicator _comm;

        public ApplicationController(MainForm gui)
        {
            _messageHub = new TinyMessengerHub();

            _settingsModel = SettingsUtils.readSettingsModelSettings(_messageHub);
            _hardwareModel = SettingsUtils.readHardwareModelSettings(_messageHub);
            _colorModel = SettingsUtils.readColorModelSettings(_messageHub);

            _colorController = new ColorController(_colorModel, _messageHub, gui);
            _temperatureController = new HardwareController(_hardwareModel, _messageHub, gui);

            _comm = new Communicator(_colorModel, _hardwareModel, _settingsModel);

            _gui = gui;
            _gui.appController = this;
            _gui.colorController = _colorController;
            _gui.settingsModel = _settingsModel;
            _gui.init(_colorModel, _hardwareModel, _messageHub);

            checkWindowState();
            //TODO: this is not working at the moment, start up the application with windows by making a sheduled task!
            //checkAutoStartStatus();
        }

        public void onGuiFormLoaded()
        {
            _colorController.autoStartMode();
            openComm();
        }

        public void openComm()
        {
            _comm.start(_gui.cmbComms.SelectedItem + "");
            _gui.setComLabels();
        }

        public void closeComm()
        {
            _comm.stop();
            _gui.setComLabels();
        }

        private void checkWindowState()
        {
            if (_settingsModel.startMinimized)
            {
                _gui.WindowState = FormWindowState.Minimized;
            }
        }

        private void checkAutoStartStatus()
        {
            String appName = "be.beeles-place.ArduinoControlCenter";
            String runKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
            Microsoft.Win32.RegistryKey startupKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(runKey);

            if (_settingsModel.startOnBoot == true)
            {
                if (startupKey.GetValue(appName) == null)
                {
                    startupKey.Close();
                    startupKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(runKey, true);
                    startupKey.SetValue(appName, Application.ExecutablePath.ToString());
                    startupKey.Close();
                }
            }
            else
            {
                startupKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(runKey, true);
                startupKey.DeleteValue(appName, false);
                startupKey.Close();
            }
            _messageHub.Publish(new SettingsModelMessage(this, "update"));
        }

        public void setAutoStartup(bool autoStart)
        {
            _settingsModel.startOnBoot = autoStart;
            checkAutoStartStatus();
        }

        public void setAutoReconnect(bool autoConnect)
        {
            _settingsModel.autoReconnect = autoConnect;
            _messageHub.Publish(new SettingsModelMessage(this, "update"));
        }

        public void setStartMinimized(bool startMinimized)
        {
            _settingsModel.startMinimized = startMinimized;
            _messageHub.Publish(new SettingsModelMessage(this, "update"));
        }

        public void dispose()
        {
            SettingsUtils.saveSettings(_hardwareModel, _settingsModel, _colorModel);

            _comm.stop();
            _colorController.dispose();
        } 
    }
}
