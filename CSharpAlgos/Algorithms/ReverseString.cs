using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Algorithms
{
    internal class ReverseString
    {
        public static char[] SolveReverseString(char[] s)
        {
            if (s.Length < 2)
            {
                return s;
            }
            int n = s.Length;
            int lPointer = 0, rPointer = n - 1;
            char c;
            while (lPointer < rPointer)
            {
                c = s[lPointer];
                s[lPointer] = s[rPointer];
                s[rPointer] = c;
                lPointer++;
                rPointer--;
            }
            return s;
        }
    }
}
