using System;
using static System.Console;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization_Deserailization
{
    [Serializable]
    class Employee

    {
        
        public int id;
        public string name;
        public int age;
        public Employee(int id,string name,int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
    }
    internal class Program
    {
        public void SerializeData()
        {
            Employee emp = new Employee(2, "Sam", 37);
            FileStream file = new FileStream("C:\\EMIAngularTraining\\employee.txt", FileMode.Open, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(file, emp);
            WriteLine("File Created Successfully!!");
            file.Close();
        }
        public void Desrialized()
        {
            Employee emp;
            FileStream file = new FileStream("C:\\EMIAngularTraining\\employee.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            emp = (Employee)binaryFormatter.Deserialize(file);
            WriteLine($"Deserialize Data is{emp.name}");
            file.Close ();
        }
        static void Main(string[] args)
        {
           Program p=new Program();
        //    p.SerializeData();
        p.Desrialized();
          
            Console.WriteLine("Hello World!");
        }
    }
}
