using GUI_Project.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace GUI_Project.ViewModel
{
    public class ManageComboBox
    {
        private DbContextOptions<DataBaseContext> dbContextOptions;

        public ManageComboBox()
        {
            dbContextOptions = new DbContextOptionsBuilder<DataBaseContext>()
                .UseSqlite("Data Source=Data Source=C:\\Users\\Computer Solution\\Desktop\\GUI_Project\\users1.db")
                .Options;
        }

        public void PopulateComboBox(ComboBox comboBox, string tableName)
        {
            using (var dbContext = new DataBaseContext(dbContextOptions))
            {
                // Retrieve the data from the specified table
                var data = dbContext.Set<ComboBoxDiseaseType>().FromSqlRaw($"SELECT * FROM {tableName}").ToList();

                // Clear the existing items in the combo box
                comboBox.Items.Clear();

                // Add the data to the combo box
                foreach (var item in data)
                {
                    comboBox.Items.Add(item);
                    
                }
            }
        }
    }
}
