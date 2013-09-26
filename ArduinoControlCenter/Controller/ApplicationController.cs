using ArduinoControlCenter.Model;
using ArduinoControlCenter.Utils.SerialComm;
using ArduinoControlCenter.Utils.Settings;
using ArduinoControlCenter.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            _settingsModel = SettingsUtils.readSettingsModelSettings();
            _settingsModel.messageHub = _messageHub;

            _hardwareModel = SettingsUtils.readHardwareModelSettings();
            _hardwareModel.messageHub = _messageHub;

            _colorModel = new ColorModel(_messageHub);

            _colorController = new ColorController(_colorModel, _messageHub, gui);
            _temperatureController = new HardwareController(_hardwareModel, _messageHub, gui);

            _comm = new Communicator(_colorModel, _hardwareModel);

            _gui = gui;
            _gui.appController = this;
            _gui.controller = _colorController;
            _gui.init(_colorModel, _hardwareModel, _messageHub);
        }

        public void openComm()
        {
            _comm.start(_gui.cmbComms.SelectedItem + "");
        }

        public void closeComm()
        {
            _comm.stop();
        }

        public void dispose()
        {
            SettingsUtils.saveSettings(_hardwareModel, _settingsModel);

            _comm.stop();
            _colorController.dispose();
        }

    }
}
