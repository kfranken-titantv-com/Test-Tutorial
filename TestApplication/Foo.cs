using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApplication
{
    class Foo
    {
        public static long Fib(long n)
        {
            var t = new Dictionary<long, long>();
            Func<long, long> fib = null;
            fib = x =>
                {
                    if (t.ContainsKey(x))
                        return t[x];
                    if (x <= 1)
                        return x;
                    long result = fib(x - 1L) + fib(x - 2L);
                    t.Add(x, result);
                    return result;
                };
            return fib(n);
        }

    }

}
