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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            this.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(random.Next(0, 256)), Convert.ToByte(random.Next(0, 256)), Convert.ToByte(random.Next(0, 256))));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.Show();
            this.Close();
        }
    }
}
