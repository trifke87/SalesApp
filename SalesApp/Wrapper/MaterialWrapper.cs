using SalesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.Wrapper
{
    public class MaterialWrapper
    {
        public MaterialWrapper(Material model)
        {
            Model = model;
        }

        public string PartNumber
        {
            get { return Model.PartNumber; }
            set { Model.PartNumber = value; }
        }
        public Material Model { get; set; }
    }
}
