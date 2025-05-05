using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieSSozdaniemClassov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Employee();
            Console.ReadKey();
        }
    }
    internal class Person
    {

    }
    public class Employee : Person
    {

    }
}
