using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var color = Color.FromArgb(0, 0, 0);
            panelColor.BackColor = color;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            var red = trackBarRed.Value;
            var green = trackBarGreen.Value;
            var blue = trackBarBlue.Value;
            var color = Color.FromArgb(red, green, blue);
            panelColor.BackColor = color;
        }
    }
}