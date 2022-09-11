using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<TextBox> inputTextBoxes;
        public Form1()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.AutoSize = true;
            this.Padding = new Padding(0, 0, 20, 20);
            this.StartPosition = FormStartPosition.CenterScreen;


        }


        private void button1_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(textBox1.Text);
            inputTextBoxes = new List<TextBox>();
            for (int i = 0 - 1; i <= number; i++)
            {
                Label label = new Label();
                TextBox textBox = new TextBox();
                label.Text = "Input " + i;
                label.Location = new Point(30, textBox.Bottom + (i * 30));
                label.AutoSize = true;
                textBox.Location = new Point(label.Width, label.Top - 3);
                inputTextBoxes.Add(textBox);
                this.Controls.Add(label);
                Controls.Add(textBox);
            }

            Button button = new Button();
            button.Text = "Add";
            button.Location = new Point(this.Width / 2 - button.Width / 2,
                inputTextBoxes[inputTextBoxes.Count - 1].Bottom + 20);
            button.Click += new EventHandler(buttonClik);
            this.Controls.Add(button);
            this.CenterToScreen();
            
        }

        void buttonClik(object s,EventArgs args)
        {
            int sum = 0;
            foreach (TextBox inputTextBox in inputTextBoxes)
            {
                if (textBox1.Text == String.Empty)
                {
                    
                }
                else
                {
                    sum += Int32.Parse(textBox1.Text);
                }
            }

            MessageBox.Show(sum + "");
        }
    }
}