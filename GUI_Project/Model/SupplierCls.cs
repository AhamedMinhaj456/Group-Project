using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project.Model
{
    public partial class SupplierCls
    {

        [Key]
        public int Id { get; set; }

        public string? CompanyName { get; set; }

        public int ContactNo { get; set; }
        public string? ProductName { get; set; }

        public string? ProductType { get; set; }
        public string? PurchasedDate { get; set; }
        public int QuanityPurchased { get; set; }
        public int PurchasePrice { get; set; }
        public int? SellingPrice { get; set; }
    }
}
