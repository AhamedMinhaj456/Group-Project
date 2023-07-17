using GUI_Project.Pages;
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
    /// Interaction logic for StaffWindow.xaml
    /// </summary>
    public partial class StaffWindow : Window
    {
        public StaffWindow()
        {
            InitializeComponent();
        }
        private void btnAdmitPatient_Click(object sender, RoutedEventArgs e)
        {
            AdmitpatientPage objAdmitPatient = new AdmitpatientPage();
            staffFrame.NavigationService.Navigate(objAdmitPatient);
        }

        private void btnReleasePatient_Click(object sender, RoutedEventArgs e)
        {
            ReleasePatientPage objReleasePatient = new ReleasePatientPage();
            staffFrame.NavigationService.Navigate(objReleasePatient);
        }

        private void btnTakeAppointment_Click(object sender, RoutedEventArgs e)
        {
            //TakeAppointmentPage objTakeAppointment = new TakeAppointmentPage();
            //staffFrame.NavigationService.Navigate(objTakeAppointment);
        }

        private void btnBloodBank_Click(object sender, RoutedEventArgs e)
        {
            //BloodBankPage objBloodBank = new BloodBankPage();
            //staffFrame.NavigationService.Navigate(objBloodBank);
        }

        private void btnAppointmentStatus_Click(object sender, RoutedEventArgs e)
        {
            //AppointmentStatusPage objAppointmentStatus = new AppointmentStatusPage();
            //staffFrame.NavigationService.Navigate(objAppointmentStatus);
        }

        private void btnAddView_Click(object sender, RoutedEventArgs e)
        {
            SupplierPage objSupplier = new SupplierPage();
            staffFrame.NavigationService.Navigate(objSupplier);
        }

        private void btnDispensary_Click(object sender, RoutedEventArgs e)
        {
            Pharmacy objDispensary = new Pharmacy();
            staffFrame.NavigationService.Navigate(objDispensary);
        }


        private void btnViewSchedule_Click(object sender, RoutedEventArgs e)
        {
            //ViewDoctorsSchedulePage objViewDoctorsSchedulePage = new ViewDoctorsSchedulePage();
            //staffFrame.NavigationService.Navigate(objViewDoctorsSchedulePage);
        }

        private void btnPatientDetails_Click(object sender, RoutedEventArgs e)
        {
            PatientDetails obj = new PatientDetails();
            staffFrame.NavigationService.Navigate(obj);
        }
        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Admin_Login objMainWindow = new Admin_Login();
            objMainWindow.Show();
            this.Close();
        }

        private void btnUpdateInfo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
