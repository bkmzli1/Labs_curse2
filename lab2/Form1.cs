using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private readonly Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы и не сомневались, что Вы так думаете!", "Мы знали!", MessageBoxButtons.OK);
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
                return;
            button2.Location = new Point(r.Next(ClientRectangle.Width - 5),
                r.Next(ClientRectangle.Height - 5));
        }
    }
}