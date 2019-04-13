using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Entity;

namespace Task.Service.Interface
{
    public interface IProductService
    {
        void AddNewProduct(Product NewProduct);
        List<Product> GetAllMyProduct();
        Product GetById(int id);
        void Update(Product UpdatedProduct,int id);
        void Delete(Product DeleteProduct);
    }
}
