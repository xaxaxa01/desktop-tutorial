using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace лабораторная5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public MainWindow()
        //{
        //    InitializeComponent();
        //    Button.Click += Button1_Click;
            
        //}

        //private void RadioButton_Click(object sender, RoutedEventArgs e)
        //{
        //    RadioButton selectedRadio = (RadioButton)e.Source;
        //    textBlock1.Text = "Вы выбрали: " + selectedRadio.Content.ToString();
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("hi from Button_Click");
        //}

        //private void Button1_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("hi from Button1_Click");
        //}

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            textBlock1.Text += e.Key.ToString();
            if (e.Key == Key.OemQuotes)
                textBlock1.Text += "'"; // добавляем кавычки
            else
                textBlock1.Text += e.Key.ToString();
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            textBlock2.Text += e.Key.ToString();
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            textBlock3.Text += e.Key.ToString();
        }

        private void TextBox_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            textBlock4.Text += e.Key.ToString();
        }

        private void TextBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            textBlock5.Text += e.Text;
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            textBlock6.Text += e.Text;
        }

        //private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Получение фокуса");
        //}



    }
}
