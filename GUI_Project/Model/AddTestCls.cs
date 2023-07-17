using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project.Model
{
    public partial class AddTestCls
    {
        [Key]
        public int Id { get; set; }

        public string? TestName { get; set; }

        public string? DiseaseType { get; set; }
        public string? DiseaseName { get; set; }
        public int TestCost { get; set; }
    }
}
