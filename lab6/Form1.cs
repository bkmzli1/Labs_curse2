using System;
using System.Drawing;
using System.Windows.Forms;


namespace lab6
{
    public partial class Form1 : Form
    {
        private Form2 form2 = new Form2();
        private Form3 form3 = new Form3();
        public Form1()
        {
            
            InitializeComponent();
            AddOwnedForm(form2);
            AddOwnedForm(form3);
            form2.Location =
                new Point(Right - 10, Bottom - 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!form2.Visible)
            {
                form2.Show();
            }
            else 
                form2.Close(); 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (form3.ShowDialog() == DialogResult.OK)
                form3.button2_Click(this, EventArgs.Empty);
        }
    }
}