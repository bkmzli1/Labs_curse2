using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.FileName = @"C:\Users\Admin\Documents\VisualStudio 2015\pic\1.txt";
            openFileDialog1.Filter = "(*txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Filter = "(*txt)|*.txt|All files (*.*)|*.*";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName == null) return;
            try
            {
                var reader = new
                    StreamReader(openFileDialog1.FileName);
                textBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
            catch (FileNotFoundException no_file)
            {
                MessageBox.Show(no_file.Message, "Ошибка", MessageBoxButtons.OK);
            }
            catch (Exception Unknow_error)
            {
                MessageBox.Show(Unknow_error.Message, "Техническая ошибка", MessageBoxButtons.OK);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;

            MessageBox.Show("Записываем");
            Save_File();
        }

        private void Save_File()
        {
            try
            {
                var writer = new StreamWriter(saveFileDialog1.FileName,
                    false);
                writer.Write(textBox1.Text);
                writer.Close();
                textBox1.Modified = false;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Техническая ошибка",
                    MessageBoxButtons.OK);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Modified == false) return;

            var MessageBoxShow = MessageBox.Show(
                "Были изменения.Сохранить с изменениями?", "Простой редактор",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

            if (MessageBoxShow == DialogResult.No) return;
            if (MessageBoxShow == DialogResult.Cancel) e.Cancel = true;

            if (MessageBoxShow == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    Save_File();
                else e.Cancel = true;
            }
        }


        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
        }

        private void colorFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
        }
    }
}