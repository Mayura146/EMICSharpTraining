using System;
using System.Linq;

namespace Predicate_Linq
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<Employee> predicate = new Predicate<Employee>(Employee.GetEmployee);
            //1st way
            Employee emp=Employee.GetAllEmployee().Find(id=>predicate(id));
   
                Console.WriteLine(emp.Name);
                     // 2nd Way
            Employee emp1 = Employee.GetAllEmployee()
                .Find(delegate (Employee e)
                {
                    return e.Id == 2;
                });

            // Func Delegate
            var emp2 = Employee.GetAllEmployee().Where(x => x.Id > 1).Select(x => x.Name);
            foreach(var i in emp2)
            {
                Console.WriteLine(i);
            }
        }


    }
    }

