using GUI_Project.Pages;
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

namespace GUI_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == System.Windows.WindowState.Normal)
            {
                this.WindowState = System.Windows.WindowState.Maximized;
            }
            else
            {
                this.WindowState = System.Windows.WindowState.Normal;
            }
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {

            this.WindowState = System.Windows.WindowState.Minimized;
        }

        private void Home(object sender, RoutedEventArgs e)
        {
            var window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Features(object sender, RoutedEventArgs e)
        {
            var window = new Features();
            window.Show();
            this.Close();

        }
        
        private void Services(object sender, RoutedEventArgs e)
        {
            var window = new Services();
            window.Show();
            this.Close();
        }

        private void AboutUs(object sender, RoutedEventArgs e)
        {
            var window = new AboutUs();
            window.Show();
            this.Close();
        }

        private void Devoleped_By(object sender, RoutedEventArgs e)
        {
            var window = new Solutions();
            window.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new Admin_Login();
            window.Show();
            this.Close();
        }
    }
}
