using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_Linq
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public int salary;

        public static List<Employee> GetAllEmployee()
        {
            List<Employee> employees = new List<Employee>()
            {

                new Employee { Id = 1, Name = "Mayura", salary = 2345 },
                new Employee { Id = 2, Name = "Sam", salary = 5678 },
                new Employee { Id = 3, Name = "John", salary = 8976 }
            };
            return employees;
        }

        public static bool GetEmployee(Employee emp)
        {
            return emp.Id == 2;
        }
    }
}
