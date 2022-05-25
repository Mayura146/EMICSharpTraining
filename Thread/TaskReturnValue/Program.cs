using System;
using System.Threading.Tasks;
namespace TaskReturnValue
{
    class Employee
    {
        public int ID;
        public string Name;
        public string location;
        public Employee(int id,string name,string location)
        {
            this.ID = id;
            this.Name = name;
            this.location = location;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Task<Employee> taskReturnValue = Task.Run(() =>
            {
                Employee employee = new Employee(1, "Mayura", "Bangalore");
                return employee;
            });
            Employee e=taskReturnValue.Result;
            Console.WriteLine(e.Name);
            Console.WriteLine("Hello World!");
        }
    }
}
