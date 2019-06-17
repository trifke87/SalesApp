﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp
{
    public class Picture
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string PartNumber { get; set; }
        public string PicturePath { get; set; }
        
    }
}
