using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine("{0}\t{1}", i, Foo.Fib(i));
        }
    }
}
