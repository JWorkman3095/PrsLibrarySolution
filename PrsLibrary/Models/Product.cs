using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //only had these in here
using System.ComponentModel.DataAnnotations.Schema; // only had these in here
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsLibrary.Models {

    public class Product {

        public int Id { get; set; }
        [Required, StringLength(30)]
        public string PartNbr { get; set; }
        [Required, StringLength(30)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal Price { get; set; }
        [Required, StringLength(30)]
        public string Unit { get; set; }
        [StringLength(255)]
        public string PhotoPath { get; set; }

        public int VendorId { get; set; }
        // virtual instance required for EF to 
        // recogize FK
        public virtual Vendor Vendor { get; set; }

        public Product() { } //added
    }
}