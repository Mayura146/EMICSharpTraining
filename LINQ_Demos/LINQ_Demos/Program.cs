using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace LINQ_Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.Add(34);
            list1.Add(12);
            list1.Add(78);
            list1.Add(56);
            // query syntax
            WriteLine("Fetch all values from list");
            var result = from value in list1 select value;
            foreach (var item in result)
            {
                WriteLine(item);
            }
            WriteLine("Fetch values > 56");
            // query syntax
            var data = from value in list1 where value > 56 select value;
            foreach (var item in data)
            {
                WriteLine(item);
            }
            // Method Syntax
            WriteLine("Fetch value=> Method Syntax");
            var methodsyntax = from s in list1 where (s > 56) select s;
            foreach (var item in methodsyntax)
            {
                WriteLine(item);
            }

            WriteLine("Fetch Employee Data");
            //query syntax
            var details = from e1 in Employee.GetEmployees() select e1;
            // Method Syntax
            var a = Employee.GetEmployees().ToList();
            foreach (var item in details)
            {
                WriteLine(item.id);
                WriteLine(item.name);
                WriteLine(item.location);
            }

            //    List<string> data1 = Employee.GetEmployees().Where(e => e.salary > 7000).Select(e1 => e1.name).ToList();
            //    foreach (var item in data1)
            //    {
            //        WriteLine(item);
            //    }
            //    WriteLine("Printing specific column");
            //    IEnumerable<Employee> emp = (from e in Employee.GetEmployees()
            //                                 select new Employee
            //                                 {
            //                                     name = e.name,
            //                                     location = e.location,
            //                                     salary = e.salary,
            //                                 }).ToList();
            //    foreach (var item in emp)
            //    {
            //        WriteLine(item.name);
            //        Write(item.location);
            //        Write(item.salary);
            //    }
            //    WriteLine(emp);
            //    WriteLine("Fetch data whose location is pune and salary >8000");
            //    var emp1 = Employee.GetEmployees().
            //        Where(x => x.salary > 7000 && x.location == "Pune").ToList();
            //    foreach (var item in emp1)
            //    {
            //        WriteLine(item.name);
            //        Write(item.location);
            //        Write(item.salary);
            //    }
            //    WriteLine("**************");
            //    WriteLine("Custom Projection");
            //    var customprojection = Employee.GetEmployees().Where(x => x.salary > 700000).
            //        Select(a => new Employee()
            //        {
            //            name = a.name,
            //            salary = a.salary / 12
            //        }).ToList();
            //    foreach(var i in customprojection)
            //    {
            //        Write(i.name);
            //        Write(i.location);
            //        Write(i.salary);

            //    }
            //// Ienumerable
            //IEnumerable<Employee> employees=Employee.GetEmployees().AsEnumerable().Where(x=>x.id >45).ToList();
            //    foreach(var i in employees)
            //    {
            //        WriteLine(i.name);
            //        WriteLine(i.location);
            //    }
            //    IQueryable<Employee> employees1 = Employee.GetEmployees().AsQueryable().Where(x => x.id > 45);

            //    WriteLine("***********Orderby***********");
            //    List<Employee> orderBy=Employee.GetEmployees().OrderBy(x=>x.salary).ToList();
            //    foreach (var i in orderBy)
            //    {
            //        WriteLine(i.name);
            //        WriteLine(i.location);
            //    }
            //    WriteLine("***********OrderbyDescending***********");
            //    List<Employee> ordeByDescending=Employee.GetEmployees().OrderByDescending(x=>x.salary).ToList();
            //    foreach (var i in ordeByDescending)
            //    {
            //        WriteLine(i.name);
            //        WriteLine(i.location);
            //    }
            //    WriteLine("*****OrderBy Descending and filter**********");
            //    List<Employee> filter=Employee.GetEmployees().Where(x=>x.location=="Pune")
            //        .OrderByDescending(x=>x.name).ToList();
            //    foreach (var i in filter)
            //    {
            //        WriteLine(i.name);

            //    }

            //    WriteLine("*******OrderBy--ThenBy******");
            //    List<Employee> employees2=Employee.GetEmployees().
            //        OrderByDescending(x=>x.name).ThenByDescending(x=>x.location).Where(x=>x.id>12).ToList();
            //    foreach (var i in employees2)
            //    {
            //        WriteLine(i.name);
            //        WriteLine(i.location);

            //    }

            //    WriteLine("****Sum Operator*****");
            //    int sumOfSalary=Employee.GetEmployees().Where(x=>x.location=="Pune").Sum(s=>s.salary);
            //    WriteLine($"Salary is {sumOfSalary}");

            //WriteLine("********Trainers Collection********");
            //var technologies=Trainer.GetTrainerDetails().SelectMany(x=>x.technologies).ToList();
            //foreach(var i in technologies)
            //{
            //    WriteLine(i);
            //}
            var uniqueRecord = Trainer.GetTrainerDetails().SelectMany(x => x.technologies).Distinct().ToList();
            foreach (var i in uniqueRecord)
            {
                WriteLine(i);
            }
            WriteLine("*****Singleor Default*************");
            var empName = Employee.GetEmployees().SingleOrDefault(s => s.name == "Mayura");
            WriteLine(empName.name);
            WriteLine("*******FindLast***********");
            var empName1 = Employee.GetEmployees().FindLastIndex(s => s.location == "Pune");
            WriteLine(empName1);
            WriteLine("*******FindAll***********");
            var empName2 = Employee.GetEmployees().FindAll(s => s.location == "Pune");
            foreach (var i in empName2)
            {
                WriteLine(i.name);
            }
            WriteLine("**************ElementAt***********");
            WriteLine("Enter the index to fetch record");
            int id = Convert.ToInt32(ReadLine());
            var indexRecord = Employee.GetEmployees().ElementAt(id);
            WriteLine(indexRecord.name);
            WriteLine("'************Take Operator***********");
            var take = Employee.GetEmployees().Where(x => x.id > 12).Take(2).ToList();
            foreach (var take1 in take)
            {
                WriteLine(take1.id);
            }


            WriteLine("******** Fetch TrainerName,Technologies************");
            var trainerDetails = (from input in Trainer.GetTrainerDetails() from data2 in input.technologies
                                 select new
                                 {
                                     name = input.name,
                                     technologies = data2
                                 }).ToList();
            foreach (var i in trainerDetails)
            {
                WriteLine(i.name);
                WriteLine(i.technologies);
            }


            WriteLine("***********GroupBy*********");
            var groupBy = Employee.GetEmployees().GroupBy(x => x.location);
            foreach (var group in groupBy)
            {
                WriteLine(group.Key);
                foreach(var i in group)
                {
                    WriteLine(i.name);
                }
            }
            
          
            }

        }


    }
    






    

// Select
// SelectMany
// IEnumerable => select query on server side=> loads in data in memory (list,array) (client side) and then filters data
// LINQ to Object,Linq to XML
//IQueryable=>remote database,service,
// select query on server side and filter
// LINQ to SQL queries