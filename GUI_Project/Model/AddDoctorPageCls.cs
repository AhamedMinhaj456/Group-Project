using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;

namespace GUI_Project.Model
{
    public partial class AddDoctorPageCls
    {
        [Key]
        public int Id { get; set; }

        public string? DoctorName { get; set; }

        public int DoctorAge { get; set; }
        //public string? BloodGroup { get; set; }

        public int? DoctorContactNo { get; set; }
        public string? DoctorAddress { get; set; }
        public string? DoctorSpcl{ get; set; }
        //public string? DoctorName { get; set; }
        public string? JoinDate { get; set; }
        public string? DoctorDept { get; set; }
        public int DoctorId { get; set; }
        public int DoctorPassword { get; set; }
        public string? ConsultingHour { get; set; }
    }
}
