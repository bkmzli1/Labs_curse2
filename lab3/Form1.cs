using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Color color = Color.FromArgb(0, 0, 0);
            panelColor.BackColor = color;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            int red = trackBarRed.Value;
            int green = trackBarGreen.Value;
            int blue = trackBarBlue.Value;
            Color color = Color.FromArgb(red, green, blue);
            panelColor.BackColor = color;
        }

      
    }
}