using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
namespace JSONSerialize_Deserialize
{
    /*using Newton/soft.json
     * JavascriptJSONSerialzer
     */
    internal class Program
    {
        public class Employee

        {
         public int id;
          public string name;
          public int age;
            
        }
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee { id = 1, name = "Mayura", age = 37 });
            list.Add(new Employee { id = 2, name = "Sam", age = 23 });
            list.Add(new Employee { id = 3, name = "Smitha", age = 24 });
            FileStream fs = new FileStream("C:\\EMIAngularTraining\\employee.json", FileMode.Open, FileAccess.Read);
      //      string json = JsonConvert.SerializeObject(list);
            //StreamWriter sw=new StreamWriter(fs);
            //sw.Write(json);
            //sw.Close();
            StreamReader sr = new StreamReader(fs);

        string s=sr.ReadToEnd();
            List<Employee> emp = JsonConvert.DeserializeObject<List<Employee>>(s);
            //while (sr.Read() !=null)
            //{

            //}
          
            Console.WriteLine("Deserialize Data");
            foreach(var i in emp)
            {
                Console.WriteLine(i.name);
            }
            fs.Close();
            Console.WriteLine("Hello World!");
        }
    }
}
