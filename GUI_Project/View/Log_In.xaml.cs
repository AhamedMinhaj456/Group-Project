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
    /// Interaction logic for Log_In.xaml
    /// </summary>
    public partial class Log_In : Window
    {
        public Log_In()
        {
            InitializeComponent();
        }

        private void textEmail_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtAdminLoginName.Focus();
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtAdminLoginName.Text)&&txtAdminLoginName.Text.Length>0)
            {
                textEmail.Visibility = Visibility.Collapsed;
            }
            else
            {
                textEmail.Visibility = Visibility.Visible;
            }
        }

        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtAdminLoginPassword.Focus();
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtAdminLoginPassword.Password) && txtAdminLoginPassword.Password.Length > 0)
            {
                textPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                textPassword.Visibility = Visibility.Visible;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textEmail.Text == "admin" && txtAdminLoginPassword.Password == "password")
            {
                var window = new Admin_Control();
                window.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("your password is incorrect!!!", "Incorrect Password");
            }


            //if(!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPassword.Password))
            //{
            //    MessageBox.Show("Successfully Signed In");
            //}
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
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

        private void Admin_Login(object sender, RoutedEventArgs e)
        {
            String username = txtAdminLoginName.Text;
            string password = txtAdminLoginPassword.Password;

            //want to add not null condition
            using (var context = new DataBaseContext())
            {
                var user = context.AdminCLs.FirstOrDefault(u => u.AdminName== username && u.AdminPassword== password);

                if (user != null)
                {
                    var window = new AdminWindow();
                    window.Show();
                    this.Close();
                    MessageBox.Show("Login successful!");
                    
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }

           
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

        private void Main_Menu(object sender, RoutedEventArgs e)
        {
            var window = new Admin_Login();
            window.Show();
            this.Close();
        }
    }
}
