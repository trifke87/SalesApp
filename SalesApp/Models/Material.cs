using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.Models
{
    public class Material : BaseModel, IDataErrorInfo
    {
        public Material()
        {
            Barcodes = new ObservableCollection<Barcode>();
            Suppliers = new ObservableCollection<Supplier>();
            //isActive = true;
            //entryDate = DateTime.Today;
        }

        private string partNumber;

        [Key]
        [MaxLength(20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string PartNumber
        {
            get { return partNumber; }
            set {
                partNumber = value;
                OnPropertyChanged("PartNumber");
            }
        }

        public ObservableCollection<Barcode> Barcodes { get; set; }

        public ObservableCollection<Supplier> Suppliers { get; set; }
        //public Supplier Supplier { get; set; }

        private string partDescription;
        public string PartDescription
        {
            get { return partDescription; }
            set
            {
                partDescription = value;
                OnPropertyChanged("PartDescription");
            }
        }
        public Picture Picture { get; set; }
        public IList<Picture> Pictures { get; set; }
        public PartCategory PartCategory { get; set; }
        public Dimension Dimensions { get; set; }
        [Required]

        private bool isActive;
        public bool IsActive
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

        //public event PropertyChangedEventHandler PropertyChanged;

        //private void OnPropertyChanged(string propertyName)
        //{
        //    if (PropertyChanged != null)
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //}

        #region IDataErrorInfo
        public string Error
        {
            get;
            private set;
        }

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "PartNumber":
                        if (String.IsNullOrWhiteSpace(PartNumber)) Error = "Polje broj dela ne moze biti prazno i ne moze sadrzati razmak";
                        else Error = null;
                        break;

                    case "PartDescription":
                        if (String.IsNullOrWhiteSpace(PartDescription)) Error = "Polje opis dela ne moze biti prazno i ne moze sadrzati razmak";
                        else Error = null;
                        break;
                    default:
                        break;
                }

                return Error;
            }
        }

        #endregion
    }
}
