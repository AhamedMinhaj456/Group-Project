using GUI_Project.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace GUI_Project.Pages
{
    public partial class UpdateDeleteDoctorPage : Page
    {
        private DataBaseContext dbContext;

        public UpdateDeleteDoctorPage()
        {
            InitializeComponent();
            dbContext = new DataBaseContext();
            LoadDoctorData();
        }

        private void LoadDoctorData()
        {
            // Retrieve the doctor data from the database
            var doctors = dbContext.addDoctorPageCls.ToList();

            // Set the data source for the data grid
            DataGridDoc.ItemsSource = doctors;
        }

        private void DataGridDoc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the selected doctor from the data grid
            var selectedDoctor = DataGridDoc.SelectedItem as AddDoctorPageCls;

            if (selectedDoctor != null)
            {
                // Update the text boxes with the selected doctor's information
                txtDocId.Text = selectedDoctor.Id.ToString();
                txtDocName.Text = selectedDoctor.DoctorName;
                txtDocAge.Text = selectedDoctor.DoctorAge.ToString();
                txtDocDept.Text = selectedDoctor.DoctorDept;
                txtDocSpecialist.Text = selectedDoctor.DoctorSpcl;
                txtDocAddress.Text = selectedDoctor.DoctorAddress;
                txtDocCouncilingHour.Text = selectedDoctor.ConsultingHour;

            }
        }

        private void btnUpdateName_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected doctor from the data grid
            var selectedDoctor = DataGridDoc.SelectedItem as AddDoctorPageCls;

            if (selectedDoctor != null)
            {
                // Update the doctor's name with the new value
                selectedDoctor.DoctorName = txtDocName.Text;

                // Save the changes to the database
                dbContext.SaveChanges();

                MessageBox.Show("Doctor's name updated successfully.", "Update");
                LoadDoctorData();
            }
        }

        private void btnUpdateAge_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected doctor from the data grid
            var selectedDoctor = DataGridDoc.SelectedItem as AddDoctorPageCls;

            if (selectedDoctor != null)
            {
                // Update the doctor's age with the new value
                selectedDoctor.DoctorAge = int.Parse(txtDocAge.Text);

                // Save the changes to the database
                dbContext.SaveChanges();

                MessageBox.Show("Doctor's age updated successfully.", "Update");
                LoadDoctorData();
            }
        }

        private void btnUpdateDept_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected doctor from the data grid
            var selectedDoctor = DataGridDoc.SelectedItem as AddDoctorPageCls;

            if (selectedDoctor != null)
            {
                // Update the doctor's department with the new value
                selectedDoctor.DoctorDept = txtDocDept.Text;

                // Save the changes to the database
                dbContext.SaveChanges();

                MessageBox.Show("Doctor's department updated successfully.", "Update");
                LoadDoctorData();
            }
        }

        private void btnUpdateSpeciality_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected doctor from the data grid
            var selectedDoctor = DataGridDoc.SelectedItem as AddDoctorPageCls;

            if (selectedDoctor != null)
            {
                // Update the doctor's specialization with the new value
                selectedDoctor.DoctorSpcl = txtDocSpecialist.Text;

                // Save the changes to the database
                dbContext.SaveChanges();

                MessageBox.Show("Doctor's specialization updated successfully.", "Update");
                LoadDoctorData();
            }
        }

        private void btnUpdateAddress_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected doctor from the data grid
            var selectedDoctor = DataGridDoc.SelectedItem as AddDoctorPageCls;

            if (selectedDoctor != null)
            {
                // Update the doctor's address with the new value
                selectedDoctor.DoctorAddress = txtDocAddress.Text;

                // Save the changes to the database
                dbContext.SaveChanges();

                MessageBox.Show("Doctor's address updated successfully.", "Update");
                LoadDoctorData();
            }
        }

        private void btnUpdateCouncilingHour_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected doctor from the data grid
            var selectedDoctor = DataGridDoc.SelectedItem as AddDoctorPageCls;

            if (selectedDoctor != null)
            {
                // Update the doctor's consulting hour with the new value
                selectedDoctor.ConsultingHour = txtDocCouncilingHour.Text;

                // Save the changes to the database
                dbContext.SaveChanges();

                MessageBox.Show("Doctor's consulting hour updated successfully.", "Update");
                LoadDoctorData();
            }
        }

        private void btnDeleteDoctor_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected doctor from the data grid
            var selectedDoctor = DataGridDoc.SelectedItem as AddDoctorPageCls;

            if (selectedDoctor != null)
            {
                // Remove the selected doctor from the DbContext
                dbContext.addDoctorPageCls?.Remove(selectedDoctor);

                // Save the changes to the database
                dbContext.SaveChanges();

                MessageBox.Show("Doctor deleted successfully.", "Delete");
                LoadDoctorData();
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
