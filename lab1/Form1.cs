using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int inputNumber = Int32.Parse(textBoxInput.Text);
            inputTextBoxes = new List<TextBox>();
            for (int i = 1; i<= inputNumber; i++)
            {
                Label labelInput = new Label();
                TextBox textBoxNewInput = new TextBox();
                labelInput.Text = "Input " + i;
                labelInput.Location = new Point(30, textBoxInput.Bottom + (i * 30));
                labelInput.AutoSize = true;
            
                textBoxNewInput.Location = new Point(labelInput.Width , labelInput.Top - 3);

                inputTextBoxes.Add(textBoxNewInput);

                this.Controls.Add(labelInput);
                this.Controls.Add(textBoxNewInput);
            }
 
            Button buttonAdd = new Button();

            buttonAdd.Text = "Add";
   
            buttonAdd.Location = new Point(this.Width / 2 - buttonAdd.Width / 2,
                inputTextBoxes[inputTextBoxes.Count - 1].Bottom + 20);

            buttonAdd.Click += new EventHandler(buttonAdd_Click);

            this.Controls.Add(buttonAdd);
            this.CenterToScreen();
        }

        void buttonAdd_Click(object sender, EventArgs e){
            int sum = 0;
            foreach (TextBox inputBox in inputTextBoxes)
            {
                if (inputBox.Text == String.Empty)
                {
                    MessageBox.Show("Please fill in all the text boxes.",
                        "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    sum += Int32.Parse(inputBox.Text);
                }
            }MessageBox.Show("The Sum is " + sum);
        }

      
    }
}