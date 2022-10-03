using System;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form2 : Form
    {
        int count = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;

                if (MessageBox.Show("Закрыть подчиненное окно?", "Подтверждение",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Hide();
                    Owner.Activate();
                }
            }
        }

        private void Form2_VisibleChanged(object sender, EventArgs e)
        {
            Owner.Controls["button1"].Text = Visible ? "Закрыть подчиненное окно" : "Открыть подчиненное окно";
            if (Visible)
            {
                label1.Text = $"Окно открыто в {++count}-й раз.";
            }
        }
    }
}