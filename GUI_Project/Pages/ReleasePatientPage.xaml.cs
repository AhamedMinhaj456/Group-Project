using GUI_Project.Model;
using GUI_Project.Model.NewFolder;
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
    /// Interaction logic for ReleasePatientPage.xaml
    /// </summary>
    public partial class ReleasePatientPage : Page
    {
        private ReleasePatientClass releasePatientClass;
        private DataBaseContext dbContext;
        public ReleasePatientPage()
        {

            InitializeComponent();

            dbContext = new DataBaseContext();
            releasePatientClass = dbContext.releasePatientClasses?.FirstOrDefault() ?? new ReleasePatientClass();
            DataContext = releasePatientClass;

            DateTime dt1;
            dt1 = DateTime.Now.Date;
            txtDateOfRelease.Text = dt1.ToString("yyyy-MM-dd");
        }

        private void btnReleasePatient_Click(object sender, RoutedEventArgs e)
        {
            using (var dbContext = new DataBaseContext())
            {
                // Get the values from the text boxes and other controls
                string patientName = txtPatientName.Text;
                string Address = txtPatientAddress.Text;
                string DateOfRelease = txtDateOfRelease.Text;
                string DateOfAdmission = txtDateOfAdmit.Text;
                string Disease = txtDisease.Text;
                string DoctorName= txtDocName.Text;
               
                int patientAge = int.Parse(txtPatientAge.Text);
                int ContactNo = int.Parse(txtContactNo.Text);
                int NoOfAdmitDays = int.Parse(txtDays.Text);
                
                int MedicineCost = int.Parse(txtMedicineCost.Text);
                int BedCost = int.Parse(txtBedCost.Text);
                int TotalCost = int.Parse(txtTotalCost.Text);
                int TestCost = int.Parse(txtTestCost.Text);
                
               

                // Create a new Patient instance and set the property values
                var patientRelease = new ReleasePatientClass
                {
                    PatientName = patientName,
                    PatientAge = patientAge,
                    DateOfRelease = DateOfRelease,
                    DateOfAdmission= DateOfAdmission,
                    Address= Address,
                    DoctorName = DoctorName,
                    Disease = Disease,
                    NoOfDays= NoOfAdmitDays,
                    MedicineCost = MedicineCost,
                    BedCost= BedCost,
                    TotalCost = TotalCost,
                    TestCost = TestCost,
                    // Set property values
                };

                // Add the patient to the DbContext
                dbContext.releasePatientClasses?.Add(patientRelease);

                // Save the changes to the database
                dbContext.SaveChanges();
            }
            MessageBox.Show("Patient Released Successfully", "Saved");
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
