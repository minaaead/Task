using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Entity;

namespace Task.Dal
{
    public class Context : DbContext
    {
        public Context():base("EvisionTask")
        {     
        }
        public DbSet<Product> Products { get; set; }
    }
}
