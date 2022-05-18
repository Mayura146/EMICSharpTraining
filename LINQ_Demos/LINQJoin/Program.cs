using System;
using System.Linq;
using static System.Console;
namespace LINQJoin
{// join on e.id=d.id
    internal class Program
    {
        static void Main(string[] args)
        {
//            WriteLine("*****Inner Join******");
//            var innerJoin = Employee.GetEmployees()// outer data source
//                .Join(Address.GetAlladdress(),// inner data source
//                employee => employee.addressId,//outer key selector
//                address => address.addressId,//inner key selector
//                (employee, address) => new
//                {
//                    EmployeeName = employee.empName,
//                    Address = address.addressLine

//                }).ToList();
//            foreach (var i in innerJoin)
//            {
//                WriteLine($"Employee Name {i.EmployeeName} => Address {i.Address}");
//            }

//            WriteLine("***********LEFT JOIN => METHOD SYNTAX********");
//            var leftjoin = Employee.GetEmployees().GroupJoin(Address.GetAlladdress(),
//                employee => employee.addressId,
//                address => address.addressId,
//                (employee, address) => new { employee, address }).SelectMany(x => x.address.DefaultIfEmpty(),
//                (employee, address) => new
//                {
//                    EmployeeName = employee.employee.empName,
//                    Address = address == null ? "Address Not Mentioned" : address.addressLine
//                });
//            foreach (var i in leftjoin)
//            {
//                WriteLine($"Employee Name {i.EmployeeName} => Address {i.Address}");
//            }

//            WriteLine("***********LEFT JOIN => Query  SYNTAX********");
//            var querySyntax = from emp in Employee.GetEmployees()
//                              join address in Address.GetAlladdress() on
//emp.addressId equals address.addressId into EmployeeAddressGroup
//                              from
//address1 in EmployeeAddressGroup.DefaultIfEmpty()
//                              select new
//                              {
//                                  EmployeeName = emp.empName,
//                                  Address = address1 == null ? "Address Not Mentioned" : address1.addressLine
//                              };

//            foreach (var i in querySyntax)
//            {
//                WriteLine($"Employee Name {i.EmployeeName} => Address {i.Address}");
//            }

            //WriteLine("***********Cross Join with Select Many=> Method Syntax********");
            //var crossjoin = Employee.GetEmployees().SelectMany(address => Address.GetAlladdress(), (emp, address) =>new
            //{
            //    Name = emp.empName,
            //    Address = address.addressLine
            //});

            //foreach (var i in crossjoin)
            //{
            //    WriteLine($"Employee Name {i.Name} => Address {i.Address}");
            //}

            //WriteLine("***********Cross Join with Join method=> Method Syntax********");
            //var joinMethod = Employee.GetEmployees().Join(Address.GetAlladdress(),
            //    employee => false,
            //    address => false, (employee, address) => new
            //    {
            //        Name = employee.empName,
            //        address = address.addressLine
            //    });

            //foreach (var i in joinMethod)
            //{
            //    WriteLine($"Employee Name {i.Name} => Address {i.address}");
            //}

            WriteLine("***********Cross Join query Syntax********");
            var crossquery = from emp in Employee.GetEmployees()
                             from address in Address.GetAlladdress()
                             select new
                             {
                                 Employee = emp.empName,
                                 Address = address.addressLine
                             };
            foreach (var i in crossquery)
            {
                WriteLine($"Employee Name {i.Employee} => Address {i.Address}");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
