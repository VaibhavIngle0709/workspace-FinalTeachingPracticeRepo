using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using moviewebapi.Models;
using moviewebapi.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace moviewebapi.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class DetailController : ControllerBase
    {
        EntDbContext context=new EntDbContext();
        [HttpGet]
        [Route("ListDetails")]
      
        // public IActionResult Get(){
        //     var data =from d in context.Details select new {MovieName=d.Movie.Name,}
        // }
        public IActionResult Get()
        {
            var data=from i in context.Details select new{i.DetailsId,i.MovieId,i.Movie.Name,i.Actor,i.Role};
            return Ok(data);
        }
 
 
        [HttpGet]
        [Route("ListDetails/{id}")]
        public IActionResult Get(int ?id)
        {
            if(id==null)
            {
                return BadRequest("Id cannot be null");
            }
            var data = (from m in context.Details where m.DetailsId==id select m).FirstOrDefault();
            return Ok(data);
        }
 
 
 
 
 
        [HttpGet]
        [Route("MovieDetails/{id}")]
        public IActionResult Get(int id)
        {
            if(id==null)
            return BadRequest("Id cannot be null");
            var data=from i in context.Details where i.MovieId==id select new{i.Actor,i.Role,i.Movie.Name,i.Movie.YearRelease};
            if(data==null)
            return NotFound("Id "+id+" is not present");
            return Ok(data);
        }
 
        [HttpPost]
        [Route("AddDetails")]
        public IActionResult Post(Detail detail)
        {
           if(ModelState.IsValid)
           {
            context.Details.Add(detail);
            context.SaveChanges();
            return Created("Record added",detail);
           }
           return BadRequest("Data is not valid");
        }
 
        [HttpPut]
        [Route("EditDetails/{id}")]
        public IActionResult Put(int id, Detail detail)
        {
            if(ModelState.IsValid)
            {
             Detail d=context.Details.Find(id);
             d.Actor=detail.Actor;
             d.MovieId=detail.MovieId;
             d.Role=detail.Role;
             d.gender=detail.gender;
             context.SaveChanges();
             return Ok();
            }
            return BadRequest("Unable to edit");
        }
       
        [HttpDelete]
        [Route("DeleteDetails/{id}")]
        public IActionResult Delete(int id)
        {
           var data=context.Details.Find(id);
           context.Details.Remove(data);
           context.SaveChanges();
           return Ok();
        }
    }
}