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

namespace GUI_Project
{
    /// <summary>
    /// Interaction logic for Print_Screen.xaml
    /// </summary>
    public partial class Print_Screen : Window
    {
        public Print_Screen()
        {
            InitializeComponent();
        }

        private void Home(object sender, RoutedEventArgs e)
        {
            var window = new Admin_Login();
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
