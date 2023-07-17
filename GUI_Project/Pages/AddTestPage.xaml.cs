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
    /// Interaction logic for AddTestPage.xaml
    /// </summary>
    public partial class AddTestPage : Page
    {
        private AddTestCls addTestCls;
        private DataBaseContext dbContext;

        public AddTestPage()
        {

            InitializeComponent();

            dbContext = new DataBaseContext();
            addTestCls = dbContext.addTestCls?.FirstOrDefault() ?? new AddTestCls();
            DataContext = addTestCls;

           

            // Retrieve the data from the table
            List<AddTestCls> testDetails = dbContext.addTestCls.ToList();

            // Set the data source for the DataGridView
            datagridViewTestList.ItemsSource = testDetails;
        
        }
        private void btnAddTest_Click(object sender, RoutedEventArgs e)
        {
            using (var dbContext = new DataBaseContext())
            {
                // Get the values from the text boxes and other controls
                string TestName = txtTestName.Text;
                string DiseaseType = comboDiseaseType.Text;
                string DiseaseName = comboDiseaseName.Text;
                int TestCost = int.Parse(txtCost.Text);



                // Create a new Patient instance and set the property values
                var Test = new AddTestCls
                {
                    TestName = TestName,
                    DiseaseType = DiseaseType,

                    DiseaseName = DiseaseName,
                    TestCost = TestCost,


                };

                // Add the patient to the DbContext
                dbContext.addTestCls?.Add(Test);

                // Save the changes to the database
                dbContext.SaveChanges();
            }
            MessageBox.Show("Test Added Successfully", "Saved");
        }



        private void comboDiseaseType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void comboDiseaseName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtCost.IsEnabled = true;
        }

        private void txtTestName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtTestName.Text.Length > 5)
            {
                comboDiseaseType.IsEnabled = true;
                comboDiseaseName.IsEnabled = false;
            }
            else
            {
                comboDiseaseType.IsEnabled = false;
                comboDiseaseName.IsEnabled = false;
            }
        }

        private void txtCost_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnAddTest.IsEnabled = true;
            comboDiseaseName.IsEnabled = false;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }


    }
}
