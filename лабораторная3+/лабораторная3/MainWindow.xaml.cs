﻿using System;
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

namespace лабораторная3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //ListBox notesList = new ListBox();
            //notesList.Items.Add("test 1");
            //notesList.Items.Add("test 2");
            //notesList.Items.Add("test 3");
            //test.Items.Add(new TabItem
            //{
            //    Header = new TextBlock { Text = "третья вкладка" },
            //    Content = notesList
            //}
            //);
        }

        //private void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        //{
        //    TreeViewItem tvItem = (TreeViewItem)sender;
        //    MessageBox.Show("Узел " + tvItem.Header.ToString() + " раскрыт");
        //}
        //private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        //{
        //    TreeViewItem tvItem = (TreeViewItem)sender;
        //    MessageBox.Show("Выбран узел: " + tvItem.Header.ToString());
        //}



    }
}
