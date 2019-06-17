using SalesApp.Models;
using SalesApp.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Data.Entity;

namespace SalesApp.ViewModels
{
    public class MaterialViewModel
    {
        
        public MaterialViewModel()
        {
            material = new Material();
            
            SaveCommand = new MaterialSave(this);
            barcode = new ObservableCollection<Barcode>();

        }

        private ObservableCollection<Barcode> barcode;

        public ObservableCollection<Barcode> Barcode
        {
            get { return barcode; }
            set
            {
                barcode = value;
            }
        }


        private Material material;

        public Material Material
        {
            get
            {
                return material;
            }
        }

        public bool CanSave
        {
            get
            {
                if (Material == null)
                {
                    return false;
                }
                return (!String.IsNullOrWhiteSpace(Material.PartNumber)&& 
                    !String.IsNullOrWhiteSpace(Material.PartDescription));
            }
        }
        public ICommand SaveCommand
        {
            get;
            private set;
        }

        public void SaveChanges()
        {
            //za cuvanje prvo mora da odradi look up, da li part number vec postoji
            //Debug.WriteLine(Material.PartNumber);
            var context = new AppContext();

            var material1 = new Material
            {
                PartNumber = Material.PartNumber,
                PartDescription = Material.PartDescription,
                IsActive = true,
                EntryDate = DateTime.Today,
                Barcodes = Material.Barcodes
            };

            context.Materials.Add(material1);

            context.SaveChanges();

        }


    }
}
