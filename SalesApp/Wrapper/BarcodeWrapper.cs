using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.Wrapper
{
    public class BarcodeWrapper : ModelWrapper<Barcode>
    {
        public BarcodeWrapper(Barcode model) : base(model)
        {
        }

        public int Id
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public string Barcode
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public bool IsActive
        {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }

        public DateTime EntryDate
        {
            get { return GetValue<DateTime>(); }
            set { SetValue(value); }
        }

        [ForeignKey("MaterialWrapper")]
        public string PartNumber
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public MaterialWrapper MaterialWrapper
        {
            get { return GetValue<MaterialWrapper>(); }
            set { SetValue(value); }
        }
    }
}
