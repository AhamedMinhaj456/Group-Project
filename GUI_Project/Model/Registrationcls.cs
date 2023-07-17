using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;

namespace GUI_Project
{
    public partial class RegistrationCls
    {
        internal static string name;

        [Key]
        public int id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public bool Sex { get; set; }
        public string? DOB { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public bool MemberShip { get; set; }

    }
}
