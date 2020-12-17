using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
namespace All_In_One_Line
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InputedText_TextChanged(object sender, TextChangedEventArgs e)
        {
            string resultProccedText = InputedText.Text.Replace(Environment.NewLine, " ");
            ResultText.Text = resultProccedText;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(ResultText.Text);
        }

        private void ResultText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
