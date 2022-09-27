using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ems;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello world");
            Console.WriteLine("Hey cg");
            Emp emp = new Emp { Id = 20, Name = "Tom", Salary = 4000 };
            Console.WriteLine($"{emp.Id} {emp.Name} {emp.Salary}");

        }
    }
}
