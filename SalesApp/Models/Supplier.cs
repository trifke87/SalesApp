using SalesApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp
{
    public class Supplier
    {
        public Supplier()
        {
            
        }
        public int Id { get; set; }

        [MaxLength(40)]
        public string SupplierNumber { get; set; }

        [MaxLength(255)]
        public string SupplierName { get; set; }

        [Required]
        public bool IsActiv { get; set; }
        [Required]
        public DateTime EntryDate { get; set; }

        [ForeignKey("Material")]
        public string PartNumber { get; set; }
        public Material Material { get; set; }

    }
}
