using SalesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.Wrapper
{
    public class MaterialWrapper : ModelWrapper<Material>
    {
        public MaterialWrapper(Material model) : base(model)
        {

        }

        public string PartNumber
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string PartDescription
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
    }
}
