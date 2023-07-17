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
    public partial class AdmitPatientPageCls
    {

        [Key]
        public int Id { get; set; }

        public string? PatientName { get; set; }

        public int PatientAge { get; set; }
        public string? BloodGroup{ get; set; }

        public int? ContactNo { get; set; }
        public string? Address { get; set; }
        public string? Disease { get; set; }
        public string? DoctorName { get; set; }
        public string? TimeOfAdmission { get; set; }
        public string? Dept { get; set; }
        public int Ward { get; set; }
        public int BedNo { get; set; }
        public string? BedType { get; set; }

    }
}
