using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CF_Migrations.Entities;

namespace EF_CF_Migrations.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Departments { get; set; }

    }
}
