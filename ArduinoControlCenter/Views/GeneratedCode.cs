using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArduinoControlCenter.Views
{
    public partial class GeneratedCodeForm : Form
    {
        public int red { get; set; }
        public int green { get; set; }
        public int blue { get; set; }

        public GeneratedCodeForm()
        {
            InitializeComponent();
        }

        private void GeneratedCodeForm_Load(object sender, EventArgs e)
        {
            String temp = rtbCode.Text;
            temp = temp.Replace("#PINRED#", red+"");
            temp = temp.Replace("#PINGREEN#", green+"");
            temp = temp.Replace("#PINBLUE#", blue+"");

            rtbCode.Text = temp;
        }
    }
}
