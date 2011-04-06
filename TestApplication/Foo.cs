using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApplication
{
    class Foo
    {
        public void ANewMethod(string input)
        {
            string copy = input.ToLower();
            copy = null;
        }
    }
}
