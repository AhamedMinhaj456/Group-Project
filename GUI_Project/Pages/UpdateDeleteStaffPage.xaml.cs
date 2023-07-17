using GUI_Project.Model;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace GUI_Project.Pages
{
    public partial class UpdateDeleteStaffPage : Page
    {
        private DataBaseContext dbContext;

        public UpdateDeleteStaffPage()
        {
            InitializeComponent();
            dbContext = new DataBaseContext();
            LoadStaffData();
        }

        private void LoadStaffData()
        {
            // Retrieve the staff data from the database
            var staffList = dbContext.addStaffCls.ToList();

            // Set the data source for the data grid
            DataGridStaff.ItemsSource = staffList;
        }

        private void DataGridStaff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the selected staff from the data grid
            var selectedStaff = DataGridStaff.SelectedItem as AddStaffClass;

            if (selectedStaff != null)
            {
                // Update the text boxes with the selected staff's information
                txtStaffId.Text = selectedStaff.StaffId.ToString();
                txtStaffName.Text = selectedStaff.StaffName;
                txtStaffAge.Text = selectedStaff.StaffAge.ToString();
                txtSTaffPost.Text = selectedStaff.post;
                txtStaffAddress.Text = selectedStaff.StaffAddress;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected staff from the data grid
            var selectedStaff = DataGridStaff.SelectedItem as AddStaffClass;

            if (selectedStaff != null)
            {
                // Update the selected staff's name
                selectedStaff.StaffName = txtStaffName.Text;

                // Save the changes to the database
                dbContext.SaveChanges();

                // Refresh the data grid
                LoadStaffData();
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected staff from the data grid
            var selectedStaff = DataGridStaff.SelectedItem as AddStaffClass;

            if (selectedStaff != null)
            {
                // Update the selected staff's age
                selectedStaff.StaffAge = int.Parse(txtStaffAge.Text);

                // Save the changes to the database
                dbContext.SaveChanges();

                // Refresh the data grid
                LoadStaffData();
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected staff from the data grid
            var selectedStaff = DataGridStaff.SelectedItem as AddStaffClass;

            if (selectedStaff != null)
            {
                // Update the selected staff's post
                selectedStaff.post = txtSTaffPost.Text;

                // Save the changes to the database
                dbContext.SaveChanges();

                // Refresh the data grid
                LoadStaffData();
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected staff from the data grid
            var selectedStaff = DataGridStaff.SelectedItem as AddStaffClass;

            if (selectedStaff != null)
            {
                // Update the selected staff's address
                selectedStaff.StaffAddress = txtStaffAddress.Text;

                // Save the changes to the database
                dbContext.SaveChanges();

                // Refresh the data grid
                LoadStaffData();
            }
        }

        private void btnDeleteStaff_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected staff from the data grid
            var selectedStaff = DataGridStaff.SelectedItem as AddStaffClass;

            if (selectedStaff != null)
            {
                // Remove the selected staff from the database
                dbContext.addStaffCls?.Remove(selectedStaff);

                // Save the changes to the database
                dbContext.SaveChanges();

                // Refresh the data grid
                LoadStaffData();

                // Clear the text fields
                ClearFields();
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private void ClearFields()
        {
            // Clear the text fields
            txtStaffId.Text = string.Empty;
            txtStaffName.Text = string.Empty;
            txtStaffAge.Text = string.Empty;
            txtSTaffPost.Text = string.Empty;
            txtStaffAddress.Text = string.Empty;
        }
    }
}
