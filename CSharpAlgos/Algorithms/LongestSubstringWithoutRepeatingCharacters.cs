using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Algorithms
{
    internal class LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            HashSet<char> chars = new HashSet<char>();
            int leftPointer = 0, result = 0;
            for (int rightPointer = 0; rightPointer < s.Length; rightPointer++)
            {
                while (chars.Contains(s[rightPointer]))
                {
                    chars.Remove(s[leftPointer]);
                    leftPointer++;
                }
                result = Math.Max(result, rightPointer - leftPointer + 1);
                chars.Add(s[rightPointer]);
            }
            return result;
        }
    }
}
