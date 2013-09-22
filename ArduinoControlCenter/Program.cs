using System;
using System.Windows.Forms;
using ArduinoControlCenter.Controller;
using ArduinoControlCenter.Views;
using ArduinoControlCenter.Model;
using TinyMessenger;

namespace ArduinoControlCenter
{
    static class Program
    {
        /// <summary>
        /// Start the application!
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainForm gui = new MainForm();

            ApplicationController applicationController = new ApplicationController(gui);

            Application.EnableVisualStyles();
            Application.Run(gui);
        }
    }
}