using GUI_Project.Model;
using GUI_Project.Model.NewFolder;
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
    /// Interaction logic for PatientDetails.xaml
    /// </summary>
    public partial class PatientDetails : Page
    {
        private DataBaseContext dbContext;
        public PatientDetails()
        {
            InitializeComponent();

            dbContext = new DataBaseContext();
            List<AdmitPatientPageCls> ViewPatients = dbContext.AdmitPatientPageCls.ToList();
            List<ReleasePatientClass> ViewReleasedPatients = dbContext.releasePatientClasses.ToList();

            // Set the data source for the DataGridView
            dataGridPatientDetails.ItemsSource = ViewPatients;
            dataGridreleasedPatientDetails.ItemsSource = ViewReleasedPatients;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
