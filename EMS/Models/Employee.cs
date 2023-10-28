using System;
using System.Collections.Generic;

namespace EMS.Models;

public partial class Employee
{
    public int EmpId { get; set; }

    public string Name { get; set; } = null!;

    public int Salary { get; set; }

    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public DateTime Dob { get; set; }

    public virtual Department IdNavigation { get; set; } = null!;
}
