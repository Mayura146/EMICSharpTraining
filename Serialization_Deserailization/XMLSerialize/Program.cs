using System;
using System.IO;
using System.Xml.Serialization;

namespace XMLSerialize
{
    [XmlRoot("EmployeeDetails")]
    public class Employee

    {
        [XmlAttribute("EmployeeId")]
        public int id;
        [XmlAttribute("EmployeeName")]
        public string name;
        [XmlAttribute("EmployeeAge")]
        public int age;
    }
        internal class Program
    {
        public void SerializeData(Employee emp)
        {
            FileStream fs = new FileStream("C:\\EMIAngularTraining\\employee.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            serializer.Serialize(fs, emp);
            fs.Close();
        }
        public void Deserialize()
        {
            Employee employee;
            FileStream fs = new FileStream("C:\\EMIAngularTraining\\employee.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
           employee = (Employee)serializer.Deserialize(fs);

            fs.Close();
            Console.WriteLine($"NAme {employee.name} age {employee.age}");
        }
        static void Main(string[] args)
        {
            Program p=new Program();    
            //Employee emp = new Employee();
            //Console.WriteLine("Enter Id,name,age");
            //emp.id = Convert.ToInt32(Console.ReadLine());  
            //emp.name = Console.ReadLine();
            //emp.age= Convert.ToInt32(Console.ReadLine());   
            //p.SerializeData(emp);
            p.Deserialize();
            Console.WriteLine("Hello World!");
        }
    }
}
