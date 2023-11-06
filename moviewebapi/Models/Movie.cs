using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace moviewebapi.Models
{
    public class Movie
    {
//         Movie 
// (Id/Name/RYear/Rating)
    [Key]
      public int Id{get;set;}
  [Required]
      public string Name{get;set;}
      public int YearRelease{get;set;}
      public int Rating{get;set;}

      public ICollection<Detail>? Details{get;set;}
          

    }
}