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

namespace GUI_Project
{
    /// <summary>
    /// Interaction logic for Features.xaml
    /// </summary>
    public partial class Features : Window
    {
        public string LongParagraph { get; set; }
        public Features()
        {
            InitializeComponent();

            LongParagraph = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                    "Pellentesque in semper justo, id rutrum neque. " +
                    "Nullam congue dapibus tellus, auctor sodales purus lobortis sed. " +
                    "Morbi eu fermentum nulla. " +
                    "Duis mollis purus et nunc consectetur, " +
                    "eu vestibulum mi aliquam. " +
                    "Fusce elementum odio lectus, vitae condimentum ligula aliquam nec. " +
                    "Sed ultrices, enim id malesuada fermentum, " +
                    "lectus metus fringilla dolor, nec dignissim nulla nulla sit amet nulla. " +
                    "Vivamus vitae malesuada arcu. " +
                    "Sed luctus lacus risus, vel auctor neque gravida nec.";

            DataContext = this;
        }

        private void Main_Menu(object sender, RoutedEventArgs e)
        {
            var window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
