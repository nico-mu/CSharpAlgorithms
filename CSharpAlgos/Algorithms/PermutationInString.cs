using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Algorithms
{
    internal class PermutationInString
    {
        public static bool CheckInclusion(string s1, string s2)
        {
            int[] cache = new int[26];
            if (s1.Length > s2.Length)
            {
                return false;
            }
            for (int i = 0; s1.Length > i; i++)
            {
                cache[s1[i] - 'a']++;
                cache[s2[i] - 'a']--;
            }
            if (validate(cache))
            {
                return true;
            }
            int leftPointer;
            for (int rightPointer = s1.Length; rightPointer < s2.Length; rightPointer++)
            {
                leftPointer = rightPointer - s1.Length;
                cache[s2[leftPointer] - 'a']++;
                cache[s2[rightPointer] - 'a']--;
                if (validate(cache))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool validate(int[] arr)
        {
            foreach (int i in arr)
            {
                if (i != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
