using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        string patch;

        public Form1()
        {
            InitializeComponent();
        }

        private Boolean FillListBox(string patch)
        {
            DirectoryInfo directory = new DirectoryInfo(patch);
            FileInfo[] files = directory.GetFiles("*.jpg");
            listBox1.Items.Clear(); //Очищаем список - если в нем что-то уже было
            foreach (FileInfo Files in files)
            {
                listBox1.Items.Add(Files.Name); //Добавляем новые компоненты в список
            }

            label1.Text = patch; //Указываем путь выбранной нами директории
            if (files.Length == 0) return false;
            else
            {
//Выбираем 1 файл из полученного списка
                listBox1.SelectedIndex = 0;
                return true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Выберите папку"; //Описание внутри диалога
            if (fbd.ShowDialog() == DialogResult.OK) //После того, как указали


            {
                patch = fbd.SelectedPath; //Записываем текущий путь в


                label1.Text = patch; //Указываем его в качестве текста компонента


                if (!FillListBox(fbd.SelectedPath)) //Если в директории нет

                    pictureBox1.Image = null;
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(patch + "\\" +
                                           listBox1.SelectedItem.ToString());
        }
    }
}