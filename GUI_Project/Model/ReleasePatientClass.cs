using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project.Model.NewFolder
{
    public partial class ReleasePatientClass
    {
        [Key]
        public int Id { get; set; }

        public string? PatientName { get; set; }

        public int PatientAge { get; set; }
        public string? DateOfRelease { get; set; }

        public int? ContactNo { get; set; }
        public string? Address { get; set; }
        public string? DoctorName { get; set; }
        public string? Disease { get; set; }
        public string? DateOfAdmission { get; set; }
        public int? NoOfDays { get; set; }
        public int MedicineCost { get; set; }
        public int BedCost { get; set; }
        public int TotalCost { get; set; }
        public int  TestCost{ get; set; }
        public string? BedType { get; set; }
    }
}
