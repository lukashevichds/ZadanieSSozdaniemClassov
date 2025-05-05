using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieSSozdaniemClassov
{
    internal class Person2
    {
        public string Name { get; set; } = "Ben";

        public Person2(string name)
        {
            Name = "Tim";
        }
    }

    class Employee2 : Person
    {
        public string Company { get; set; }

        public Employee2(string name, string company)
        : base("Bob")
        {
            Company = company;
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee2("Tom", "Microsoft") { Name = "Sam" };

            Console.WriteLine(emp.Name); // Ben Tim Bob Tom Sam
            Console.ReadKey();
        }
    }

}
