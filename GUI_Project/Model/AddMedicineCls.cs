using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project.Model
{
    public partial class AddMedicineCls
    {

        [Key]
        public int Id { get; set; }

        public string? MedicineName { get; set; }

        
        public string? DiseaseType { get; set; }

        public int? CompanyContactNo { get; set; }
        public string? DiseaseName { get; set; }
        public string? CompanyName { get; set; }
        
        public string? MedicineDate { get; set; }
        
        public int Quanity { get; set; }
        public int BuyingPrice{ get; set; }
        public int SellingPrice { get; set; }
    }
}
