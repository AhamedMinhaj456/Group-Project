// using GUI_Project.Model;
using GUI_Project.Model;
using GUI_Project.View;
using GUI_Project.ViewModel;
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
    /// Interaction logic for Admin_Login.xaml
    /// </summary>
    public partial class Admin_Login : Window
    {
        public Admin_Login()
        {

            InitializeComponent();
        }



        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private bool IsMaximize = false;

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximize)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1024;
                    this.Height = 720;

                    IsMaximize=false;

                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                    IsMaximize=true;
                }
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new Registration();
            window.Show();
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

        private void Admin_Login1(object sender, RoutedEventArgs e)
        {
            var window = new Log_In();
            window.Show();
            this.Close();

        }

        // User login Access


        private void Registration_Window(object sender, RoutedEventArgs e)
        {
            String username = txtuserLoginName.Text;
            string password = txtUserLoginPassword.Password;

            //want to add not null condition
            using (var context = new DataBaseContext())
            {
                var user = context.UserCls.FirstOrDefault(u => u.UserName == username && u.UserPassword== password);

                if (user != null)
                {
                    var window = new StaffWindow();
                    window.Show();
                    this.Close();
                    MessageBox.Show("Login successful!");
                    RegistrationCls.name = string.Empty;
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
        //{


        //    var Username = emailTxt.Text;
        //    var UserPassword = passwordTxt.Password;

        //    using (DataBaseContext context = new DataBaseContext())
        //    {
        //        bool userfound = context.UserLogins.Any(UserLogin => UserLogin.UserName == Username && UserLogin.UserPassword == UserPassword);

        //        if (userfound)
        //        {
        //            GrantAccess_ForUSer();
        //        }
        //        else
        //        {
        //            MessageBox.Show("User Name Or Password is Incorrect!!!!",
        //                "Incorrect User Name Or Password");
        //        }


        //    }

        //    using (var dbContext = new DataBaseContext())
        //    {
        //        var users = dbContext.UserLogins.ToList();
        //        foreach(var user in users)

        //        if (user.UserName == Username && user.UserPassword == UserPassword)
        //        {
        //            GrantAccess_ForUSer();
        //        }
        //        else
        //        {
        //            MessageBox.Show("User Name Or Password is Incorrect!!!!",
        //                "Incorrect User Name Or Password");
        //        }
        //    }

        //}

        //public void GrantAccess_ForUSer()
        //{
        //    var window = new Registration();
        //    window.Show();
        //    this.Close();
        //}
        // public void GrantAccess_ForUSer(string stt)
        //{

        //}

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var window = new DoctorWindow();
            window.Show();
            this.Close();
            //MessageBox.Show("Please Contact Admin for Create new Account");
        }

        private void emailTxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //var window1 = new CreateAdmin();
            //window1.Show();
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //var window1 = new CreateUser();
            //window1.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var window1 = new Admin_Control();
            window1.Show();
        }
    }
    
}
