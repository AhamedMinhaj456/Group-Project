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
    /// Interaction logic for CreateAdmin.xaml
    /// </summary>
    public partial class CreateAdmin : Window
    {
        public CreateAdmin()
        {
            InitializeComponent();
        }

        private void txtAdmin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new Log_In();
            window.Show();
            this.Close();
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

      

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Create_Admin(object sender, RoutedEventArgs e)
        {
           
                string username = txtAdminName.Text;
                string password = txtAdminPassword.Password;
                

                using (var context = new DataBaseContext())
                {
                    var Create_Admin = new CreateAdminCLs
                    {
                        AdminName = username,
                        AdminPassword = password,
                        
                    };

                    context.AdminCLs.Add(Create_Admin);
                    context.SaveChanges();

                var window = new CreateAdmin();
                window.Show();
                this.Close();
                MessageBox.Show("Admin Created Successfully!");

                }
            
        }
    }
}
