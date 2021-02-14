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

        static IEnumerable<string> Names()
        {
            yield return "Tammy";
            yield return "Cody";
            yield return "Connor";
        }

        static IEnumerable<int> Randoms()
        {
            var rand = new Random();

            
            while (true)
            {
                yield return rand.Next();
            }
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

            foreach (var r in Randoms())
            {
                //Console.WriteLine($"Found {r}");    // Creates an infinite loop
            }



        }

        static void Example2()
        {
            dynamic d1 = "String";
            dynamic d2 = 32;
            dynamic d3 = new Program();

            Print(d3);
        }

        static void Example3()
        {
            foreach (var name in Names())
            {
                Console.WriteLine($"Found {name}");
            }

        }
    }
}
