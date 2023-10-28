using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EMS.Controllers
{
    public class DeptController : Controller
    {
        private readonly ILogger<DeptController> _logger;

        public DeptController(ILogger<DeptController> logger)
        {
            _logger = logger;
        }

         public IActionResult List()
        {
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