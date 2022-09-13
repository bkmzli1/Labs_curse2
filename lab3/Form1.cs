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
            var option = trackBar12.Value;
            var color = Color.FromArgb(option,red, green, blue);
            panelColor.BackColor = color;
        }


        private void trackBar21_Scroll(object sender, EventArgs e)
        {
            var rgb = trackBar21.Value;
            var color = Color.FromArgb(rgb, rgb, rgb);
            panelColor.BackColor = color;
        }
    }
}