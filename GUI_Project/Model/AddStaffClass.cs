using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project.Model
{
    public partial class AddStaffClass
    {

        [Key]
        public int Id { get; set; }

        public string? StaffName { get; set; }

        public int StaffAge { get; set; }
        

        public string? StaffContactNo { get; set; }
        public string? post { get; set; }
        public string? StaffBloodGroup { get; set; }
        public string? StaffJoiningDate { get; set; }
        public string? StaffAddress { get; set; }

        public int StaffId { get; set; }
        public int StaffPassword { get; set; }

    }
}
