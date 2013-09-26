using ArduinoControlCenter.Model;
using ArduinoControlCenter.Utils.HardwareMonitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoControlCenter.Utils.Settings
{
    public class SettingsUtils
    {
        public static void saveSettings(HardwareModel hardwareModel, SettingsModel settingsModel) {
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

            //settings model settings
            Properties.Settings.Default.autoStartOn = settingsModel.startOnBoot;
            Properties.Settings.Default.autoReconnect = settingsModel.autoReconnect;

            Properties.Settings.Default.Save();
        }

        public static HardwareModel readHardwareModelSettings()
        {
            HardwareModel hwModel = new HardwareModel(null);
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

        public static SettingsModel readSettingsModelSettings()
        {
            SettingsModel setModel = new SettingsModel(null);

            setModel.startOnBoot = Properties.Settings.Default.autoStartOn;
            setModel.autoReconnect = Properties.Settings.Default.autoReconnect;

            return setModel;
        }
    }
}
