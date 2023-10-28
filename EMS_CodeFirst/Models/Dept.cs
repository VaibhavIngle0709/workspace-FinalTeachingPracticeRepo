using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EMS_CodeFirst.Models
{
    [Table("Department")]
    public class Dept
    {
        public int Id{get;set;}

        [Required(ErrorMessage="Name Cannot Be Blank")]
        [MaxLength(30)]
        [Column("DeptName")]
        public string Name{get;set;}

        [Column("Location")]
        [MaxLength(30)]
        public string Location{get;set;}

        public ICollection<Employee> Employee{get;set;}

        
    }
}