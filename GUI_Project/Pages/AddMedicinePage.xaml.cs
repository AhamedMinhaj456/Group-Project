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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI_Project.Pages
{
    /// <summary>
    /// Interaction logic for AddMedicinePage.xaml
    /// </summary>
    public partial class AddMedicinePage : Page
    {
        private AddMedicineCls addMedicineCls;
        private DataBaseContext dbContext;

        public AddMedicinePage()
        {

            InitializeComponent();

            dbContext = new DataBaseContext();
            addMedicineCls = dbContext.addMedicineCls?.FirstOrDefault() ?? new AddMedicineCls();
            DataContext = addMedicineCls;
        }
        private void btnAddMedicine_Click(object sender, RoutedEventArgs e)
        {
            using (var dbContext = new DataBaseContext())
            {
                // Get the values from the text boxes and other controls
                string MedicineName = txtMedicineName.Text;
                
                string CompanyName = txtCompanyName.Text;
                string MedicineDate = txtDate.Text;
                int CompanyContactNo = int.Parse(txtContactNo.Text);
                int Quanity = int.Parse(txtQuantity.Text);
                int BuyingPrice = int.Parse(txtBuyingPrice.Text);
                int SellingPrice = int.Parse(txtSellingPrice.Text);

                string DiseaseType = comboDiseaseType.Text;
                string DiseaseName = comboDiseaseName.Text;
                // Get other values as needed

                // Create a new Patient instance and set the property values
                var Medicine = new AddMedicineCls
                {
                    MedicineName = MedicineName,
                    DiseaseType = DiseaseType,

                    DiseaseName = DiseaseName,
                    CompanyName = CompanyName,

                    MedicineDate = MedicineDate,
                    CompanyContactNo = CompanyContactNo,
                    Quanity = Quanity,
                    BuyingPrice = BuyingPrice,
                    SellingPrice = SellingPrice,
                    
                    // Set property values
                };

                // Add the patient to the DbContext
                dbContext.addMedicineCls?.Add(Medicine);

                // Save the changes to the database
                dbContext.SaveChanges();
            }
            MessageBox.Show("Medicine Details Added Successfully", "Saved");
        }

        private void txtMedicineName_TextChanged(object sender, TextChangedEventArgs e)
        {
            //more codes
        }

        private void comboDiseaseType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnAddMedicine.IsEnabled = true;
        }

        private void comboDiseaseName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnAddMedicine.IsEnabled = true;
        }

        private void txtCompanyName_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnAddMedicine.IsEnabled = true;
        }

        private void txtContactNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnAddMedicine.IsEnabled = true;
        }

        private void txtDate_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnAddMedicine.IsEnabled = true;
        }

        private void txtQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnAddMedicine.IsEnabled = true;
        }

        private void txtBuyingPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnAddMedicine.IsEnabled = true;
        }

        private void txtSellingPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnAddMedicine.IsEnabled = true;
        }

        
       

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
