using SalesApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            InitializeCollectionProperties(model);
        }

        private void InitializeCollectionProperties(Material model)
        {
            if (model.Barcodes == null)
            {
                throw new ArgumentException("Barcode cannot be null");
            }
            Barcodes = new ObservableCollection<BarcodeWrapper>(
                model.Barcodes.Select(e => new BarcodeWrapper(e)));
            RegisterCollection(Barcodes, model.Barcodes);
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

        public ObservableCollection<BarcodeWrapper> Barcodes { get; private set; }
    }
}
