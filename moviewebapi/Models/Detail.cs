using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace moviewebapi.Models

{
//     Details
// (DetailsId/Actor/MovieId/Gender/Role)
    public class Detail
    {
        [Key]
        public int DetailsId{get;set;}
        [Required]
        [MaxLength(30)]
        public string Actor{get;set;}
        [ForeignKey("Movie")]
        public int MovieId{get;set;}
        public string gender{get;set;}
        public string Role{get;set;}
        public Movie? Movie{get;set;}

    }
}