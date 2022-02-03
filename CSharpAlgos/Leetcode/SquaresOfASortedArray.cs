using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Leetcode
{
    internal class SquaresOfASortedArray
    {
        public static int[] SortedSquares(int[] nums)
        {
            int[] res = new int[nums.Length];
            int n = nums.Length;
            int i = 0, j = n - 1;
            int p = n - 1;
            while (p >= 0)
            {
                int iSquare = (int)Math.Pow(nums[i], 2);
                int jSquare = (int)Math.Pow(nums[j], 2);
                if (iSquare <= jSquare)
                {
                    res[p] = jSquare;
                    j--;
                }
                else
                {
                    res[p] = iSquare;
                    i++;
                }
                p--;
            }
            return res;
        }
    }
}
