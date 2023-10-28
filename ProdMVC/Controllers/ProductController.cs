using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProdMVC.Models;


namespace ProdMVC.Controllers
{
    
    public class ProductController : Controller
    {

        private readonly DemoDatabaseContext context;
        public ProductController(DemoDatabaseContext _context)
        {
            context=_context;
        }
     
     public IActionResult List()
     {
        var data=context.Product.ToList();
        return View(data);
     }
       public IActionResult Display(int id)
     {
        var data=context.Product.Find(id);
        return View(data);
     }

      public IActionResult Create()
     {
        
        return View();
     }
     [HttpPost]
      public IActionResult Create(Product prod)
     {
        if(ModelState.IsValid)
        {
            context.Product.Add(prod);
            context.SaveChanges();
            return RedirectToAction("List");
        }
        return View();
     }
        public IActionResult Edit(int id)
     {
        var data=context.Product.Find(id);
        return View(data);
     }
        [HttpPost]
        public IActionResult Edit(Product prod)
     {
        if(ModelState.IsValid)
        {
          Product product=context.Product.Find(prod.Id);
          product.Name=prod.Name;
          product.Price=prod.Price;
          product.Stock=prod.Stock;  
          context.SaveChanges();
          return RedirectToAction("List");   
        }
        return View();
     }

    public IActionResult Delete(int id)
     {
        var data=context.Product.Find(id);
        return View(data);
     }
     [HttpPost]
      public IActionResult Delete(Product prod)
     {
        Product product=context.Product.Find(prod.Id);
        context.Product.Remove(product);
        context.SaveChanges();
        return RedirectToAction("List");
     }


        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}