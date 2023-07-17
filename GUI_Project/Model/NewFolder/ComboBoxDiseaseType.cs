using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project.Model
{
    public partial class ComboBoxDiseaseType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
