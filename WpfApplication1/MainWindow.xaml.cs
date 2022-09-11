using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication1
{

    public partial class MainWindow
    {
        private List<TextBox> inputTextBoxes;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            int inputNumber = Int32.Parse(textInput.Text);
            inputTextBoxes = new List<TextBox>();
            for (int i = inputNumber - 1; i >= 0; i--)
            {
                Label label = new Label();
                TextBox textBox = new TextBox();
                


            }
         
        }
    }
}