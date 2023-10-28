using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS_CodeFirst.Models
{   
    [Index(nameof(Email),IsUnique=true)]
    public class Employee
    {
        [Key]
        public int EmpId{get;set;}

        [MaxLength(30)]
        public string Name{get;set;}
        public int Salary{get;set;}

        [ForeignKey("Dept")]
        public int Id{get;set;}


        [MaxLength(40)]
       
        public string Email{get;set;}
        public DateTime DOB{get;set;}

        public Dept Dept{get;set;}
    }
}