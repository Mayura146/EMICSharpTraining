using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Demos
{
    internal class Trainer
    {
        public int id;
        public string name;
        public string location;
        public List<string> technologies;
        public int Experience;

        public static List<Trainer> GetTrainerDetails()
        {
            List<Trainer> list = new List<Trainer>();
            list.Add(new Trainer

            {
                id=1,
                name="Poorva",
                location="Pune",
                technologies=new List<string> { "C","C++","Java","WPF"},
                Experience=12
            });
            list.Add(new Trainer

            {
                id = 1,
                name = "Tushar",
                location = "Mumbai",
                technologies = new List<string> { "C", "C++", "Java", "WPF" },
                Experience = 3
            }) ;
            list.Add(new Trainer

            {
                id = 1,
                name = "Heda",
                location = "Delhi",
                technologies = new List<string> { "ETL","C#"},
                Experience=15
            });
            return list;
        }
    }
}
