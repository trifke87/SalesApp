using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesApp.Models;

namespace SalesApp
{
    class AppContext : DbContext
    {
        public DbSet<Material> Materials { get; set; }
        public DbSet<Barcode> Barcodes { get; set; }
        public DbSet<Dimension> Dimensions { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<PartCategory> PartCategories { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public AppContext()
        {

        }
    }

}
