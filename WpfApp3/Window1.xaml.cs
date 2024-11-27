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
using System.Windows.Shapes;

namespace WpfApp3
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void rb1_Checked(object sender, RoutedEventArgs e)
        {
            if(sender is RadioButton radioButton)
            {
                switch (radioButton.Name)
                {
                    case "rb1":
                        imgDisplay.Source = new BitmapImage(new Uri("C:/Users/andre/Downloads/images/cat1.jpg"));
                        break;
                    case "rb2":
                        imgDisplay.Source = new BitmapImage(new Uri("C:/Users/andre/Downloads/images/cat2.jpg"));
                        break;
                    case "rb3":
                        imgDisplay.Source = new BitmapImage(new Uri("C:/Users/andre/Downloads/images/cat3.jpg"));
                        break;
                }
            }
        }
    }
}
