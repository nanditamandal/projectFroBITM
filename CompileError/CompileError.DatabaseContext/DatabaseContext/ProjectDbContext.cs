using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompileError.Model.Model;

namespace CompileError.DatabaseContext.DatabaseContext
{
    public class ProjectDbContext:DbContext
    {
     
        public DbSet<Customer> Customers { get; set; }
     
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public DbSet<SalesDetail> SalesDetails { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
    
}
