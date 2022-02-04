using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Leetcode
{
    internal class MoveZeros
    {
        public static int[] MoveZeroes(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                return nums;
            }
            int n = nums.Length;
            int leftp = 0, rightp = 1;
            while (rightp < n && leftp < n)
            {
                if (nums[leftp] == 0)
                {
                    if (nums[rightp] != 0)
                    {
                        nums[leftp] = nums[rightp];
                        nums[rightp] = 0;
                    }
                    else
                    {
                        rightp++;
                    }
                }
                else
                {
                    leftp++;
                    rightp++;
                }
            }
            return nums;
        }
    }
}
