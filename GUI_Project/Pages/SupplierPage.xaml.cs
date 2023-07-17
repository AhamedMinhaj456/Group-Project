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
    /// Interaction logic for SupplierPage.xaml
    /// </summary>
    public partial class SupplierPage : Page
    {
         private SupplierCls supplierCls;
        private DataBaseContext dbContext;
        public SupplierPage()
        {
            InitializeComponent();
            load_table();
            //fill_combo();

            dbContext = new DataBaseContext();

            // Retrieve the data from the table
            List<SupplierCls> SupplierDetails = dbContext.supplierCls.ToList();

            // Set the data source for the DataGridView
            datagridSupplier.ItemsSource = SupplierDetails;
        

        
            supplierCls = dbContext.supplierCls?.FirstOrDefault() ?? new SupplierCls();
            DataContext = supplierCls;
        }

        private void btnAddSupplier_Click(object sender, RoutedEventArgs e)
        {
            using (var dbContext = new DataBaseContext())
            {
                // Get the values from the text boxes and other controls
                string CompanyName = txtCompanyName.Text;
                int ContactNo = int.Parse(txtContactNo.Text);
                string ProductName = txtProductName.Text;
                string PurchasedDate = datepicker1.Text;
                string ProductType = comboBoxProductType.Text;
                int QuanityPurchased = int.Parse(txtQuanityPurchased.Text);
                int PurchasePrice = int.Parse(txtPurchaseprice.Text);
                int SellingPrice = int.Parse(txtSellingPrice.Text);



                // Create a new Patient instance and set the property values
                var supplier = new SupplierCls
                {
                    CompanyName = CompanyName,
                    ContactNo = ContactNo,
                    ProductName = ProductName,
                    ProductType = ProductType,
                    PurchasedDate = PurchasedDate,
                    QuanityPurchased = QuanityPurchased,
                    PurchasePrice = PurchasePrice,
                    SellingPrice = SellingPrice,
                    
                };

                // Add the patient to the DbContext
                dbContext.supplierCls?.Add(supplier);

                // Save the changes to the database
                dbContext.SaveChanges();
            }
            MessageBox.Show("Supplier Details Added Successfully", "Saved");
        }

        void load_table()
        {
        
        }


            
        
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        int i = 1;
        private void Refresh_Click_1(object sender, RoutedEventArgs e)
        {
            if (i == 1)
            {
                load_table();
                i = 0;
            }
            else
            {
                load_table();
                i = 1;
            }
        }
    }
}
