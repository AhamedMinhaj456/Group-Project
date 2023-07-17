using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project.Model.NewFolder
{
    public partial class ComboBoxDepartment
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
