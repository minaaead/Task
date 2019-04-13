using EVisionTask.Models;
using StructureMap.Building;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Task.Entity;

namespace EVisionTask.Helper
{
    public class ClassHelper
    {
        public Product Mapper(ProductModel ProductToMap)
        {
            Product Product = new Product
            {
                Name = ProductToMap.Name,
                Photo = ProductToMap.PhotoPath,
                Price = ProductToMap.Price,
                LastUpdated = System.DateTime.Now
            };
            return Product;
        }
        public ProductModel Mapper(Product ProductToMap)
        {
            ProductModel Product = new ProductModel
            {
                Name = ProductToMap.Name,
                PhotoPath = ProductToMap.Photo,
                Price = ProductToMap.Price
            };
            return Product;
        }
        public string GetMyFilePath (HttpPostedFileBase myfile, string Name, HttpServerUtilityBase Server)
        {
            string path = "";
            string fileName = "";
            if (myfile.ContentLength > 0)
            {
                // extract only the fielname
                 fileName = Path.GetFileName(Name+myfile.FileName);
                // store the file inside ~/App_Data/uploads folder
                 path = Path.Combine(Server.MapPath("~/uploads"), fileName);
                myfile.SaveAs(path);
            }
            string RelativePath = "~/uploads/" + fileName;
            return RelativePath;
        }
    }
}