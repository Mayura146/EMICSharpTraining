using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    internal class EmployeeDetails
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{Id =1,Name="Mayura",location="Bangalore"},
                new Employee{Id =2,Name="Amit",location ="Pune"}

            };
            return employees;
        }
    }
}
