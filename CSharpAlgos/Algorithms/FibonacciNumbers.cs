using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Algorithms
{
    internal class FibonacciNumbers
    {
        int[] cache;
        public int CalcFibonacci(int n)
        {
            cache = new int[n + 1];
            return DynamicFib(n);
        }

        public int DynamicFib(int n)
        {
            if (n <= 1)
            {
                cache[n] = 1;
            }
            if (cache[n] == 0)
            {
                cache[n] = DynamicFib(n - 1) + DynamicFib(n - 2);
            }
            return cache[n];
        }
    }
}
