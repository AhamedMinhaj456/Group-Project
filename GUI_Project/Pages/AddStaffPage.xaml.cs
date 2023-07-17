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
    /// Interaction logic for AddStaffPage.xaml
    /// </summary>
    public partial class AddStaffPage : Page
    {
        private AddStaffClass addStaffClass;
        private DataBaseContext dbContext;

        public AddStaffPage()
        {

            InitializeComponent();

            dbContext = new DataBaseContext();
            addStaffClass = dbContext.addStaffCls?.FirstOrDefault() ?? new AddStaffClass();
            DataContext = addStaffClass;
        }
        private void btnAddStaff_Click(object sender, RoutedEventArgs e)
        {
            using (var dbContext = new DataBaseContext())
            {
                // Get the values from the text boxes and other controls
                string StaffName = txtStaffName.Text;
                int StaffAge = int.Parse(txtStaffAge.Text);
                string StaffContactNo = txtContactNo.Text;
                string Post = txtPost.Text;
                string StaffBloodGroup = txtBloodGrp.Text;
                string StaffJoiningDate= datepicker.Text;
                string StaffAddress= txtStaffAddress.Text;
                int StaffId = int.Parse(txtStaffId.Text);
                int StaffPassword = int.Parse(txtStaffPasswrod.Text);


                // Create a new Patient instance and set the property values
                var Staff = new AddStaffClass
                {
                    StaffName = StaffName,
                    StaffAge = StaffAge,

                    StaffContactNo = StaffContactNo,
                    post = Post,
                    StaffBloodGroup = StaffBloodGroup,
                    StaffJoiningDate = StaffJoiningDate,
                    StaffAddress = StaffAddress,
                    StaffId = StaffId,
                    StaffPassword = StaffPassword,

                };

                // Add the patient to the DbContext
                dbContext.addStaffCls?.Add(Staff);

                // Save the changes to the database
                dbContext.SaveChanges();
            }
            MessageBox.Show("Staff Details Added Successfully", "Saved");
        }

        
        

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
