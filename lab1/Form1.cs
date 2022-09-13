using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        private List<TextBox> inputTextBoxes;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            var inputNumber = int.Parse(textBoxInput.Text);
            inputTextBoxes = new List<TextBox>();
            for (var i = 1; i <= inputNumber; i++)
            {
                var labelInput = new Label();
                var textBoxNewInput = new TextBox();
                labelInput.Font = new Font("Times New Roman", i*5);
                labelInput.ForeColor = Color.FromArgb(i*10,i*10,i*10);
                var linkLabel = new LinkLabel();
                linkLabel.Text = i+"";
                linkLabel.LinkClicked+=new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
                labelInput.Text = "Input " + i;
                labelInput.Location = new Point(30, textBoxInput.Bottom + i * 30);
                labelInput.AutoSize = true;

                textBoxNewInput.Location = new Point(labelInput.Width, labelInput.Top - 3);
                linkLabel.Location= new Point(textBoxNewInput.Width+200, textBoxNewInput.Top - 3);
                inputTextBoxes.Add(textBoxNewInput);

                Controls.Add(labelInput);
                Controls.Add(textBoxNewInput);
                Controls.Add(linkLabel);
            }

            var buttonAdd = new Button();
            var buttonAddD = new Button();

            buttonAdd.Text = "Add";
            buttonAddD.Text = "AddD";

            buttonAdd.Location = new Point(Width / 2 - buttonAdd.Width / 2,
                inputTextBoxes[inputTextBoxes.Count - 1].Bottom + 20);
            buttonAddD.Location = new Point(Width / 2 - buttonAdd.Width / 2,
                inputTextBoxes[inputTextBoxes.Count - 1].Bottom + 40);
            
            buttonAdd.Click += buttonAdd_Click;
            buttonAddD.DoubleClick += new System.EventHandler(this.buttonAdd_DClick);

            Controls.Add(buttonAdd);
            Controls.Add(buttonAddD);
            CenterToScreen();
        }
        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;
            System.Diagnostics.Process.Start("http://"+linkLabel.Text);
        }
        private void buttonAdd_DClick(object sender, EventArgs e)
        {
            
                    MessageBox.Show("Please fill in all the text boxes.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var sum = 0;
            foreach (var inputBox in inputTextBoxes)
                if (inputBox.Text == string.Empty)
                {
                    MessageBox.Show("Please fill in all the text boxes.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    sum += int.Parse(inputBox.Text);
                }

            MessageBox.Show("The Sum is " + sum);
        }
    }
}