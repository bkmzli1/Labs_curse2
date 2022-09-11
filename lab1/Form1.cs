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
                labelInput.Text = "Input " + i;
                labelInput.Location = new Point(30, textBoxInput.Bottom + i * 30);
                labelInput.AutoSize = true;

                textBoxNewInput.Location = new Point(labelInput.Width, labelInput.Top - 3);

                inputTextBoxes.Add(textBoxNewInput);

                Controls.Add(labelInput);
                Controls.Add(textBoxNewInput);
            }

            var buttonAdd = new Button();

            buttonAdd.Text = "Add";

            buttonAdd.Location = new Point(Width / 2 - buttonAdd.Width / 2,
                inputTextBoxes[inputTextBoxes.Count - 1].Bottom + 20);

            buttonAdd.Click += buttonAdd_Click;

            Controls.Add(buttonAdd);
            CenterToScreen();
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