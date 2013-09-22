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
    public partial class ColorPickerDialog : Form
    {
        public Color selectedColor = Color.White;

        public ColorPickerDialog()
        {
            InitializeComponent();
        }

        private void ColorPickerDialog_Load(object sender, EventArgs e)
        {
            colorChooser11.nudBrightness.Value = 255;
        }

        private void colorChooser11_ColorChanged(object sender, EventArgs e)
        {
            selectedColor = colorChooser11.SelectedColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
