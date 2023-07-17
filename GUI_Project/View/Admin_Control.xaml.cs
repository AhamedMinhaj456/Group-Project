using GUI_Project.Model;
using GUI_Project.View;
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
    /// Interaction logic for Admin_Control.xaml
    /// </summary>
    public partial class Admin_Control : Window
    {
        private DataBaseContext dbContext;
        public Admin_Control()
        {
            InitializeComponent();


            dbContext = new DataBaseContext();

            // Retrieve the data from the table
            List<CreateAdminCLs> ViewAdmin = dbContext.AdminCLs.ToList();
            List<CreateUserCls> ViewUser = dbContext.UserCls.ToList();

            // Set the data source for the DataGridView
            dataGridAdmin.ItemsSource = ViewAdmin;
            dataGridUser.ItemsSource = ViewUser;
        }


        private void Home(object sender, RoutedEventArgs e)
        {
            var window = new Admin_Login();
            window.Show();
            this.Close();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            var window = new Log_In();
            window.Show();
            this.Close();
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            Log_In objMainWindow = new Log_In();
            objMainWindow.Show();
            this.Close();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            var window1 = new CreateAdmin();
            window1.Show();


        }

        private void PIButton_Click(object sender, RoutedEventArgs e)
        {
            var window2 = new CreateUser();
            window2.Show();

        }

        private void AcademicButton_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow objMainWindow = new AdminWindow();
            objMainWindow.Show();
            this.Close();
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
    }
}
