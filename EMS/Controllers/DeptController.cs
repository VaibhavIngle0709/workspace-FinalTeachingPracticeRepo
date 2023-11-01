using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EMS.Models;

namespace EMS.Controllers
{
    public class DeptController : Controller
    {
        private readonly EmsDbContext context;

        public DeptController(EmsDbContext _context)
        {
            context=_context;
        }
         public IActionResult List()
        {
            return View();
        }


         public IActionResult Create()
     {
        
        return View();
     }
     [HttpPost]
      public IActionResult Create(Department department)
     {
        if(ModelState.IsValid)
        {
            context.Departments.Add(department);
            context.SaveChanges();
            return RedirectToAction("List");
        }
        return View();
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





