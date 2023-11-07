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
    public class MovieController : ControllerBase
    {
        EntDbContext context=new EntDbContext();

        [HttpGet]
        [Route("ShowMovies")]
        public IActionResult GetShowMovies()
        {
            var data=context.Movie_VMs.FromSqlInterpolated<Movie_VM>($"MovieInfo");
            return Ok(data);
        }


        [HttpGet]
        [Route("ListMovies")]
        public IActionResult Get()
        {
            var data=context.Movies.ToList();
            return Ok(data);
        }
        [HttpGet]
        [Route("ListMovies/{id}")]
            public IActionResult Get(int id)
        {
            if(id==null)
            {
                return BadRequest("Your are bad request");
            }
            var data=context.Movies.Find(id);
            if(data==null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpPost]
        [Route("AddMovies")]
        public IActionResult Post(Movie movie)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    context.Movies.Add(movie);
                    context.SaveChanges();

                }
                catch(Exception ex)
                {
                    return BadRequest(ex.InnerException.Message);
                }
            }
            return Created("Added Successfully",movie);
        }

        [HttpPut]
        [Route("EditMovie/{id}")]
        public IActionResult Put(int id,Movie movie)
        {
            if(ModelState.IsValid)
            {
                Movie omovie=context.Movies.Find(id);
                omovie.Name=movie.Name;
                omovie.Rating=movie.Rating;
                omovie.YearRelease=movie.YearRelease;
                context.SaveChanges();
                return Ok();
            }
            return BadRequest("Unable To Edit Record");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
            var detail=context.Details.Where(d=>d.MovieId==id);
            if(detail.Count() !=0)
            {
                throw new Exception("Cannot Delete Movie");
            }

            var data=context.Movies.Find(id);
            context.Movies.Remove(data);
            context.SaveChanges();
            return Ok("");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }

        }
        [HttpGet]
        [Route("DisplayMovies/{Rating}/{Year}")]
        public IActionResult Get(int Rating,int Year)
        {
            var data=from m in context.Movies where m.Rating==Rating && m.YearRelease==Year select m;
            if(data.Count()==0)
            {
                return NotFound("No Movies Found");
            }
            return  Ok(data);
        }

        [HttpGet]
        [Route("DisplayByRating")]
        public IActionResult GetDisplayByRating([FromQuery] int rating)
        {
            var data=context.Movies.Where(m=>m.Rating==rating);
            if(data.Count()==0)
            {
                return NotFound("No Movies in rating");
            }
            return Ok(data);
        }


        
    }
}