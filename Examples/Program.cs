using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Program
    {
        static void Print(Program p)
        {
            Console.WriteLine("I got a program object");
        }

        static void Main(string[] args)
        {
            Example1();
        }

        static void Example1()
        {
            var names = new string[] { "Tammy", "Cody", "Connor" };

            var nameList = new List<String>();
            nameList.Add("Tammy");
            nameList.Add("Cody");
            nameList.Add("Connor");

            foreach (var name in names)
            {
                Console.WriteLine($"Found {name}");
            }

        }

        static void Example2()
        {
            dynamic d1 = "String";
            dynamic d2 = 32;
            dynamic d3 = new Program();

            Print(d3);
        }
    }
}
