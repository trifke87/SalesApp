using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp
{
    class Price
    {
        [Key]
        [MaxLength(20)]
        public string PartNumber { get; set; }
        //[Column(TypeName="Money")]
        public decimal PartPrice { get; set; }
    }
}
