using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private Random Random = new Random();

        internal void button2_Click(object sender, EventArgs e)
        {
            Owner.Text = textBox1.Text;
            Owner.OwnedForms[0].Text = textBox2.Text;
            Owner.OwnedForms[1].Text = textBox2.Text;
            Owner.OwnedForms[1].Text = textBox2.Text;
            Owner.OwnedForms[1].Width = Convert.ToInt32(textBox3.Text);
            Owner.OwnedForms[1].Height = Convert.ToInt32(textBox4.Text);
            Owner.OwnedForms[1].BackColor = Color.FromArgb(Random.Next(0, Convert.ToInt32(textBox5.Text)),
                Random.Next(0, Convert.ToInt32(textBox5.Text)), Random.Next(0, Convert.ToInt32(textBox5.Text)));
        }

        private void Form3_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
                ActiveControl = textBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}