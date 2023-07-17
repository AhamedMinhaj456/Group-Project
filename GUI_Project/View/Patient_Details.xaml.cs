using GUI_Project.Model;
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
    /// Interaction logic for Patient_Details.xaml
    /// </summary>
    public partial class Patient_Details : Window
    {
        private DataBaseContext dbContext;
        public Patient_Details()
        {
            InitializeComponent();

            dbContext = new DataBaseContext();

            // Retrieve the data from the table
            List<AddDoctorPageCls> addDoctors = dbContext.addDoctorPageCls.ToList();

            // Set the data source for the DataGridView
            dataGridView11.ItemsSource = addDoctors;
        }

        private void Home(object sender, RoutedEventArgs e)
        {
            var window = new Admin_Login();
            window.Show();
            this.Close();
        }

        private void Print_Screen(object sender, RoutedEventArgs e)
        {
            var window = new Print_Screen();
            window.Show();
            this.Close();
        }
    }
}
