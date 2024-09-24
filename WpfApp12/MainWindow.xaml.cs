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
using System.Collections;
using Microsoft.Win32;

namespace WpfApp12
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
            OpenFileDialog ka = new OpenFileDialog();
            if(ka.ShowDialog() == true)
            {
                img1.Source = new BitmapImage(new Uri(ka.FileName));
            }
        }

     
                

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(txt1.Text);
            int b = Convert.ToInt32(txt2.Text);
            int c = Convert.ToInt32(txt3.Text);
            int d = (b / a) * c;
            txt4.Text = "Сумма равно " + d;
        }
    }
}
