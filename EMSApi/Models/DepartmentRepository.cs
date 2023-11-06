using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMSApi.Models
{
    public class DepartmentRepository:IDepartment
    {
        EmsDbContext context=new EmsDbContext();
        public override void AddDept(Department dept)
        {
            context.Departments.Add(dept);
            context.SaveChanges();
        }
        public void DeleteDept(int id)
        {
            Department d=context.Departments.Find(id);
            
        }
        public void EditDept(Department dept)
        {

        }
        public void FindDept(int id)
        {
                var data=context.Departments.Find(id);
                
                
        }
        public List<Department> GetDepartments()
        {
            return context.Departments.ToList();
        }

    }
}