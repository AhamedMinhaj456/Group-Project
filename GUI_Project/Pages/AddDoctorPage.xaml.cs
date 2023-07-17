using GUI_Project.Model;
using GUI_Project.ViewModel;
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
using static MaterialDesignThemes.Wpf.Theme;

namespace GUI_Project.Pages
{
    /// <summary>
    /// Interaction logic for AddDoctorPage.xaml
    /// </summary>
    public partial class AddDoctorPage : Page
    {
        private AddDoctorPageCls AddDoctorPageCls;
        private DataBaseContext dbContext;
       // private ManageComboBox manageComboBox;

        public AddDoctorPage()
        {
             
                 InitializeComponent();

            dbContext = new DataBaseContext();

           // manageComboBox = new ManageComboBox();

            // Populate ComboBox1
           // manageComboBox.PopulateComboBox(txtDoctorDept, "comboBoxDiseaseTypes");

            AddDoctorPageCls = dbContext.addDoctorPageCls?.FirstOrDefault() ?? new AddDoctorPageCls();
            DataContext = AddDoctorPageCls;
        }
        private void btnAddDoctor_Click(object sender, RoutedEventArgs e)
        {
            using (var dbContext = new DataBaseContext())
            {
                // Get the values from the text boxes and other controls
                string DoctorName = txtDoctorname.Text;
                string DoctorAddress = txtDoctorAddress.Text;
                string DoctorSpcl = txtDoctorSpl.Text;
                string ConsultingHour = txtConsultingHr.Text;
                string JoinDate = datepicker.Text;
                int DoctorAge = int.Parse(txtDoctorAge.Text);
                int DoctorContactNo = int.Parse(txtDoctorContactNo.Text);
                int DoctorPassword= int.Parse(txtDoctorId.Text);
                int DoctorId= int.Parse(txtDoctorPass.Text);
                
                string DoctorDept = txtDoctorDept.Text;
                // Get other values as needed

                // Create a new Patient instance and set the property values
                var Doctor = new AddDoctorPageCls
                {
                    DoctorName = DoctorName,
                    DoctorAge= DoctorAge,
                    
                    DoctorContactNo= DoctorContactNo,
                    DoctorAddress= DoctorAddress,
                    
                    DoctorSpcl= DoctorSpcl,
                    ConsultingHour= ConsultingHour,
                    DoctorDept= DoctorDept,
                    JoinDate= JoinDate,
                    DoctorId= DoctorId,
                    DoctorPassword= DoctorPassword,
                    // Set property values
                };

                // Add the patient to the DbContext
                dbContext.addDoctorPageCls?.Add(Doctor);

                // Save the changes to the database
                dbContext.SaveChanges();
            }
            MessageBox.Show("Doctor Added Successfully", "Saved");
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
