using ArduinoControlCenter.Model;
using ArduinoControlCenter.Utils.HardwareMonitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinyMessenger;

namespace ArduinoControlCenter.Utils.Settings
{
    public class SettingsUtils
    {
        public static void saveSettings(HardwareModel hardwareModel, SettingsModel settingsModel, ColorModel colorModel) {
            //hardware model settings
            Properties.Settings.Default.dp1Speed = hardwareModel.dataPoints[0].speed;
            Properties.Settings.Default.dp1Temp = hardwareModel.dataPoints[0].temperature;

            Properties.Settings.Default.dp2Speed = hardwareModel.dataPoints[1].speed;
            Properties.Settings.Default.dp2Temp = hardwareModel.dataPoints[1].temperature;

            Properties.Settings.Default.dp3Speed = hardwareModel.dataPoints[2].speed;
            Properties.Settings.Default.dp3Temp = hardwareModel.dataPoints[2].temperature;

            Properties.Settings.Default.dp4Speed = hardwareModel.dataPoints[3].speed;
            Properties.Settings.Default.dp4Temp = hardwareModel.dataPoints[3].temperature;

            Properties.Settings.Default.dp5Speed = hardwareModel.dataPoints[4].speed;
            Properties.Settings.Default.dp5Temp = hardwareModel.dataPoints[4].temperature;

            Properties.Settings.Default.quietModeOn = hardwareModel.quietModeEnabled;
            Properties.Settings.Default.quitModeSpeed = hardwareModel.quietModeSpeed;

            //color model settings
            //TODO: default mode
            Properties.Settings.Default.staticStartColor = colorModel.color;

            //settings model settings
            Properties.Settings.Default.autoStartOn = settingsModel.startOnBoot;
            Properties.Settings.Default.autoReconnect = settingsModel.autoReconnect;
            Properties.Settings.Default.startMinimized = settingsModel.startMinimized;

            Properties.Settings.Default.Save();
        }

        public static HardwareModel readHardwareModelSettings(TinyMessengerHub messageHub)
        {
            HardwareModel hwModel = new HardwareModel(messageHub);
            LinearDataPoint ldp1 = new LinearDataPoint(Properties.Settings.Default.dp1Temp, Properties.Settings.Default.dp1Speed);
            LinearDataPoint ldp2 = new LinearDataPoint(Properties.Settings.Default.dp2Temp, Properties.Settings.Default.dp2Speed);
            LinearDataPoint ldp3 = new LinearDataPoint(Properties.Settings.Default.dp3Temp, Properties.Settings.Default.dp3Speed);
            LinearDataPoint ldp4 = new LinearDataPoint(Properties.Settings.Default.dp4Temp, Properties.Settings.Default.dp4Speed);
            LinearDataPoint ldp5 = new LinearDataPoint(Properties.Settings.Default.dp5Temp, Properties.Settings.Default.dp5Speed);

            List<LinearDataPoint> dps = new List<LinearDataPoint>();
            dps.Add(ldp1);
            dps.Add(ldp2);
            dps.Add(ldp3);
            dps.Add(ldp4);
            dps.Add(ldp5);

            hwModel.dataPoints = dps;
            hwModel.quietModeEnabled = Properties.Settings.Default.quietModeOn;
            hwModel.quietModeSpeed = Properties.Settings.Default.quitModeSpeed;
            return hwModel;
        }

        public static ColorModel readColorModelSettings(TinyMessengerHub messageHub)
        {
            ColorModel colModel = new ColorModel(messageHub);
            colModel.color = Properties.Settings.Default.staticStartColor;

            return colModel;
        }

        public static SettingsModel readSettingsModelSettings(TinyMessengerHub messageHub)
        {
            SettingsModel setModel = new SettingsModel(messageHub);

            setModel.startOnBoot = Properties.Settings.Default.autoStartOn;
            setModel.autoReconnect = Properties.Settings.Default.autoReconnect;
            setModel.startMinimized = Properties.Settings.Default.startMinimized;

            return setModel;
        }
    }
}
