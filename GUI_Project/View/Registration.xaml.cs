using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public object id { get; internal set; }

        private RegistrationCls registrationCls;
        private DataBaseContext dbContext;

        public Registration()
        {
            InitializeComponent();
           

            dbContext = new DataBaseContext();
            registrationCls = dbContext.registrations.FirstOrDefault() ?? new RegistrationCls();
            DataContext = registrationCls;

            //DateTime dt1;
            //dt1 = DateTime.Now.Date;
            //txtDOB.Text = dt1.ToString("yyyy-MM-dd");
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime selectedDate = datePicker.SelectedDate ?? DateTime.MinValue; // Get the selected date

            //DOB.Text = selectedDate.ToString("dd/MM/yyyy"); // Assign the selected date to the text field
        }


        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
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

        private void Home_Window(object sender, RoutedEventArgs e)
        {
            var window = new Admin_Login();
            window.Show();
            this.Close();
        }

        private void Main_menu(object sender, RoutedEventArgs e)
        {
            var window = new Admin_Login();
            window.Show();
            this.Close();
        }

        private void Registration_2(object sender, RoutedEventArgs e)
        {
            if (dbContext.registrations.Any())
            {
                dbContext.registrations.Update(registrationCls);
            }
            else
            {
                dbContext.registrations.Add(registrationCls);
            }

            dbContext.SaveChanges();
            MessageBox.Show("Data saved successfully!");
        

        var window = new Registration_2 {
                DataContext = registrationCls
            };
            window.Show();
            this.Close();
        }

        private void myOption_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private string selectedGender;

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            selectedGender = (sender as RadioButton).Content.ToString();
        }

        private void myOption_MouseDown(object sender, MouseButtonEventArgs e)
        {
            bool Gender = true;
        }
    }
}
