using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Demos
{
    internal class Employee
    {
        public int id;
        public string name;
        public string location;
        public int salary;
        // select name,location,salary from Employee
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { id = 45, name = "Mayura", location = "Bangalore", salary = 456767 });
            employees.Add(new Employee { id = 79, name = "Amit", location = "Pune", salary = 789377 });
            employees.Add(new Employee { id = 12, name = "Smitha", location = "Delhi", salary = 567897 });
            employees.Add(new Employee { id = 78, name = "Sameer", location = "Pune", salary = 98757 });
            return employees;
        }
    }
}
