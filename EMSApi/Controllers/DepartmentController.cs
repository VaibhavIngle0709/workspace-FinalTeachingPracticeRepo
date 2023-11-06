using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EMSApi.Models;

namespace EMSApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController : ControllerBase
    {
        IDepartment repo;
        public DepartmentController(IDepartment _repo)
        {
            this.repo=_repo;
        }  

        [HttpGet]
        [Route("ListDept")]
        public IActionResult GetDept()
        {
            var data=repo.GetDepartments();
            return Ok(data);
        } 
        [HttpPost]
        [Route("Create")]
        public IActionResult PostDept(Department d)
        {
            if(ModelState.IsValid)
            {
                repo.AddDept(d);
                return Ok("Added Successfully");
            }
            return BadRequest("Unable to add");

        }
    }
}