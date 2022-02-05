using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Leetcode
{
    internal class ReverseWordsInString3
    {
        public static string ReverseWords(string s)
        {
            if (s.Length < 2)
            {
                return s;
            }
            string[] split = s.Split(' ');
            char[] res = new char[s.Length];
            int index = 0;
            foreach (string sub in split)
            {
                int lPointer = 0, rPointer = sub.Length - 1;
                while (lPointer <= rPointer)
                {
                    res[index + lPointer] = sub[rPointer];
                    res[index + rPointer] = sub[lPointer];
                    lPointer++;
                    rPointer--;
                }
                index += sub.Length;
                if (index < res.Length)
                {
                    res[index] = ' ';
                    index++;
                }
            }
            return new string(res);
        }
    }
}
