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
    /// Interaction logic for Registration_2.xaml
    /// </summary>
    public partial class Registration_2 : Window
    {
        private RegistrationCls2 registrationCls2;
        private DataBaseContext dbContext;
        public Registration_2()
        {
            InitializeComponent();

            dbContext = new DataBaseContext();
            registrationCls2 = dbContext.registration_2s.FirstOrDefault() ?? new RegistrationCls2();
            DataContext = registrationCls2;

            
        }

        private void Previous_Page(object sender, RoutedEventArgs e)
        {
            var window = new Registration();
            window.Show();
            this.Close();
        }

        private void Home_Window(object sender, RoutedEventArgs e)
        {
            var window = new Admin_Login();
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

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Save(object sender, RoutedEventArgs e)
        {
            if (dbContext.registration_2s.Any())
            {
                using (var context = new DataBaseContext())
                {
                    dbContext.registration_2s.Update(registrationCls2);
                }
            }
            else
            {
                dbContext.registration_2s.Add(registrationCls2);
            }

            dbContext.SaveChanges();
            MessageBox.Show("Data saved successfully!");


            var window = new Patient_Details();
            window.Show();
            this.Close();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
