using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Leetcode
{
    internal class KDiffPairsInAnArray
    {
        public static int FindPairs(int[] nums, int k)
        {
            int res = 0;

            Array.Sort(nums);
            int leftPointer = 0, rightPointer = 1;
            // [1, 1, 3, 4, 5]
            while (leftPointer < nums.Length && rightPointer < nums.Length)
            {
                int temp = nums[rightPointer] - nums[leftPointer];
                if (leftPointer == rightPointer)
                {
                    rightPointer++;
                    continue;
                }
                if (temp == k)
                {
                    res++;
                    temp = nums[leftPointer];
                    if (temp == nums[rightPointer])
                    {
                        while (rightPointer < nums.Length && nums[rightPointer] == temp)
                        {
                            rightPointer++;
                        }
                    }
                    else
                    {
                        while (leftPointer < nums.Length && nums[leftPointer] == temp)
                        {
                            leftPointer++;
                        }
                    }

                }
                else if (temp < k)
                {
                    rightPointer++;
                }
                else
                {
                    leftPointer++;
                }
            }

            return res;
        }
    }
}
