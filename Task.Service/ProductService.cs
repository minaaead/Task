using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Entity;
using Task.Repository.Interface;
using Task.Service.Interface;

namespace Task.Service
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository ProRepository;
        public ProductService(IProductRepository ProRepository)
        {
            this.ProRepository = ProRepository;
        }
        public void AddNewProduct(Product NewProduct)
        {
            ProRepository.ADD(NewProduct);
        }
        public List<Product> GetAllMyProduct()
        {
            return ProRepository.GetAll();
        }
        public Product GetById (int id)
        {
            return ProRepository.GetById(id);
        }
        public void Update (Product UpdatedProduct,int id)
        {
            UpdatedProduct.ID = id;
            ProRepository.Update(UpdatedProduct);
        }
        public void Delete (Product DeleteProduct)
        {
            ProRepository.Delete(DeleteProduct.ID);
        }




    }
}
