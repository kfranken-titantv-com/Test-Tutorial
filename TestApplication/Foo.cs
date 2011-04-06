using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApplication
{
    class Foo
    {
        public string AnAdditionalMethod(string x)
        {
            if (!String.IsNullOrEmpty(x))
                return x.ToLower();
            else
                return String.Empty;
        }
        
        public void ANewMethod(string input)
        {
            string copy = input.ToLower();
            copy = null;
        }

        public static int Fib(int n)
        {
            if (n < 2)
                return 1;
            else
                return Fib(n - 1) + Fib(n - 2);
        }

    }

}
