using GUI_Project.Model;
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

namespace GUI_Project.View
{
    /// <summary>
    /// Interaction logic for CreateUser.xaml
    /// </summary>
    public partial class CreateUser : Window
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("This Window Cannot maximize", "Error");
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Create_User(object sender, RoutedEventArgs e)
        {
            string username = txtCreateUser.Text;
            string password = txtCreatePassword.Password;


            using (var context1 = new DataBaseContext())
            {
                var Create_User = new CreateUserCls
                {
                    UserName = username,
                    UserPassword = password,

                };

                context1.UserCls.Add(Create_User);
                context1.SaveChanges();

                var window = new CreateUser();
                window.Show();
                this.Close();
                MessageBox.Show("User Created Successfully!");

            }
        }

       

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }

        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
