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
    public class Barcode
    {

        public Barcode()
        {

            isActive = true;
            entryDate = DateTime.Today;
        }

        public int Id { get; set; }

        [MaxLength(50)]
        public string BarcodeNumber { get; set; }
        [Required]

        private bool isActive;
        public bool IsActiv
        {
            get { return isActive; }
            set { isActive = value; }
        }
        [Required]

        private DateTime entryDate;
        public DateTime EntryDate
        {
            get { return entryDate; }
            set { entryDate = value; }
        }

        [ForeignKey("Material")]
        public string PartNumber { get; set; }
        public Material Material { get; set; }

    }
}
