using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMSApi.Models
{
    public class DepartmentRepository:IDepartment
    {
        EmsDbContext context=new EmsDbContext();
        public void AddDept(Department dept)
        {
            context.Departments.Add(dept);
            context.SaveChanges();
        }
        public void DeleteDept(int id)
        {
            Department d=context.Departments.Find(id);
            context.Departments.Remove(d);
            context.SaveChanges();
        }
        public void EditDept(Department dept)
        {
            Department department=context.Departments.Find(dept.Id);
            department.DeptName=dept.DeptName;
            department.Location=dept.Location;
            context.SaveChanges();
        }
        public Department FindDept(int id)
        {
                var data=context.Departments.Find(id);
                return data;
                
        }
        public List<Department> GetDepartments()
        {
            return context.Departments.ToList();
        }

    }
}