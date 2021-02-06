using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Foo <T>
    {
        private T tField;
        public T Prop { get; set; }
        public void PrintIt()
        {
            Console.WriteLine(tField);
        }

        public T DoNothingWithThis(T t)
        {
            tField = t;
            return tField;
        }

    }
}
