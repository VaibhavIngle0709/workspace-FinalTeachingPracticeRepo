using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using StdApp.Models;
using System.Data;

namespace StdApp.Controllers
{
   
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        public IActionResult List()
        {
            string constr="User ID=sa;password=examlyMssql@123; server=localhost;Database=DemoDatabase;trusted_connection=false;Persist Security Info=False;Encrypt=False";
            SqlConnection con=new SqlConnection(constr);
            SqlCommand command=new SqlCommand("Select * from Student",con);
            con.Open();
            SqlDataReader reader=command.ExecuteReader();

            DataTable stdTable=new DataTable();
            stdTable.Load(reader);

            return View(stdTable);

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