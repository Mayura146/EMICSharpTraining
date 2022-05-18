using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQJoin
{
    class Employee
    {
        public int empId;
        public string empName;
        public int addressId;
        public static List<Employee> GetEmployees() => new List<Employee>()
            {
                new Employee { empId = 1, empName = "Preety", addressId = 1 },
                new Employee { empId = 2, empName = "Priyanka", addressId = 2 },
                new Employee { empId = 3, empName = "Anurag", addressId = 3 },
                new Employee { empId = 4, empName = "Pranaya", addressId = 4 },
                new Employee { empId = 5, empName = "Hina", addressId = 5 },
                new Employee { empId = 6, empName = "Sambit", addressId = 6 },
                new Employee { empId = 7, empName = "Hina", addressId = 7 },
                new Employee { empId = 8, empName = "Tarun", addressId = 8 },
                new Employee { empId = 9, empName = "Santosh", addressId = 9 },
                new Employee { empId = 10, empName = "Rana", addressId = 10 },
                new Employee { empId = 11, empName = "Sudhanshu", addressId = 11 }

            };
    }
}
