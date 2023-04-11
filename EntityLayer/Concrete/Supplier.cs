using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAbout { get; set; }
        public string SupplierMail { get; set; }
        public string SupplierPassword { get; set; }
        public string SupplierImage { get; set; }
        public string SupplierThumbnailImage { get; set; }
        public bool SupplierStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}
