using EVisionTask.Helper;
using EVisionTask.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task.Entity;
using Task.Service.Interface;

namespace EVisionTask.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService ProService;
        private readonly ClassHelper Helper;
        public ProductController(IProductService ProService, ClassHelper Helper)
        {
            this.ProService = ProService;
            this.Helper = Helper;
        }
        // GET: Product
        public ActionResult Index()
        {
            return View(ProService.GetAllMyProduct());
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View(ProService.GetById(id));
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View(new ProductModel());
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductModel NewProduct)
        {
            try
            {
                NewProduct.PhotoPath= Helper.GetMyFilePath(NewProduct.ImageFile, NewProduct.Name, Server);
                // TODO: Add insert logic here
                ProService.AddNewProduct(Helper.Mapper(NewProduct));
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Helper.Mapper(ProService.GetById(id)));
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ProductModel UpdatedProduct)
        {
            try
            {
                // TODO: Add update logic here
                if(UpdatedProduct.ImageFile != null)
                {
                    UpdatedProduct.PhotoPath = Helper.GetMyFilePath(UpdatedProduct.ImageFile, UpdatedProduct.Name, Server);
                }
                ProService.Update(Helper.Mapper(UpdatedProduct),id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View(ProService.GetById(id));
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Product DeletePro)
        {
            try
            {
                // TODO: Add delete logic here
                ProService.Delete(DeletePro);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
    }
}
