using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadanieSSozdaniemClassov;

namespace ZadanieSSozdaniemClassov
{
    internal class Auto
    {
        public int Seats { get; set; } // количество сидений
        public Auto(int seats);
        Seats a = new seats();
    }
    
      
}

class Truck : Auto // грузовой автомобиль
{
    public decimal Capacity { get; set; } // грузоподъемность
    public Truck(int seats, decimal capacity)
    {
        Seats = seats;
        Capacity = capacity;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Truck truck = new Truck(2, 1.1m);
        Console.WriteLine($"Грузовик с грузоподъемностью {truck.Capacity} тонн");
        Console.ReadKey();
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieSSozdaniemClassov
{
    internal class Auto2
    {
        public int Seats { get; set; } // количество сидений
        public Auto()
        {
            Console.WriteLine("Auto has been created");
            
        }
        public Auto(int seats)
        {
            Seats = seats;
        }
    }
    class Truck : Auto // грузовой автомобиль
    {
        public decimal Capacity { get; set; } // грузоподъемность
        public Truck(decimal capacity)
        {
            Seats = 2;
            Capacity = capacity;
            Console.WriteLine("Truck has been created");
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            Truck truck = new Truck(1.1m);
            Console.WriteLine($"Truck with capacity {truck.Capacity}");
            Console.ReadKey();
        }
    }
}



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
