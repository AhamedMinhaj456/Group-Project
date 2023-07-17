using GUI_Project.Model;
using GUI_Project.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for AdmitpatientPage.xaml
    /// </summary>
    public partial class AdmitpatientPage : Page
    {
        private AdmitPatientPageCls AdmitPatientPageCls;
        private DataBaseContext dbContext;
        public AdmitpatientPage()
        {
            InitializeComponent();

            dbContext = new DataBaseContext();
            AdmitPatientPageCls = dbContext.AdmitPatientPageCls?.FirstOrDefault() ?? new AdmitPatientPageCls();
            DataContext = AdmitPatientPageCls;
        }

        private void SavingAdmitPatientPage(object sender, RoutedEventArgs e)
        {
            using (var dbContext = new DataBaseContext())
            {
                // Get the values from the text boxes and other controls
                string patientName = patient_name.Text;
                string Address = patient_address.Text;
                //string Disease = patient_name.Text;
                //string DoctorName= patient_name.Text;
                string TimeOfAdmission = time_of_admission.Text;
                string Dept = textboxDoctorDept.Text;
                string BedType = textboxBedType.Text;
                int patientAge = int.Parse(patient_age.Text);
                int ContactNo = int.Parse(patient_contact_no.Text);
                int WardNo = int.Parse(textboxWard.Text);
                int BedNo = int.Parse(textboxBed.Text);
                string bloodGroup = comboboxBloodGroup.Text;
                string Disease = comboboxDisease.Text;
                string DoctorName = comboboxDoctorName.Text;
                // Get other values as needed

                // Create a new Patient instance and set the property values
                var patient = new AdmitPatientPageCls
                {
                    PatientName = patientName,
                    PatientAge = patientAge,
                    BloodGroup = bloodGroup,
                    ContactNo = ContactNo,
                    Address = Address,
                    Disease = Disease,
                    DoctorName= DoctorName,
                    TimeOfAdmission = TimeOfAdmission,
                    Dept = Dept,
                    Ward= WardNo,
                    BedNo= BedNo,
                    BedType= BedType,
                    // Set property values
                };

                // Add the patient to the DbContext
                dbContext.AdmitPatientPageCls?.Add(patient);

                // Save the changes to the database
                dbContext.SaveChanges();

                

               
            }

            MessageBox.Show("Patient Details Added Successfully", "Saved");
        }

       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private void patient_age_TextChanged(object sender, TextChangedEventArgs e)
        {
            comboboxBloodGroup.IsEnabled = true;
        }

        private void patient_name_TextChanged(object sender, TextChangedEventArgs e)
        {
            patient_age.IsEnabled = true;
        }

        private void comboboxBloodGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            patient_address.IsEnabled = true;
        }

        private void patient_address_TextChanged(object sender, TextChangedEventArgs e)
        {
            comboboxDisease.IsEnabled = true;
        }

        private void patient_contact_no_TextChanged(object sender, TextChangedEventArgs e)
        {
            patient_name.IsEnabled = true;
        }

        private void comboboxDisease_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboboxDoctorName.IsEnabled = true;
        }

        private void comboboxDoctorName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
