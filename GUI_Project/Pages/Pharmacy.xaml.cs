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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI_Project.Pages
{
    /// <summary>
    /// Interaction logic for Pharmacy.xaml
    /// </summary>
    public partial class Pharmacy : Page
    {
        private DataBaseContext dbContext;
        public Pharmacy()
        {
            InitializeComponent();

            InitializeComponent();
            dbContext = new DataBaseContext();

            List<AddMedicineCls> addMedicine = dbContext.addMedicineCls.ToList();
            medicineDetails.ItemsSource = addMedicine;

            List<AddTestCls> addTest = dbContext.addTestCls.ToList();


            TestDetails.ItemsSource = addTest;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
