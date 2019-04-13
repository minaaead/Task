using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Dal;
using Task.Entity;
using Task.Repository.Interface;

namespace Task.Repository
{
   public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(Context MyContext):base(MyContext)
        {
                
        }
    }
}
