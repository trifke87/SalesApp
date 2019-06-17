using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp
{
    public class Dimension
    {
        [Key]
        public string PartNumber { get; set; }
        public float Height { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public float Weight { get; set; }

        [Required]
        public bool IsActiv { get; set; }
        [Required]
        public DateTime EntryDate { get; set; }
    }
}
