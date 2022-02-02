using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Algorithms
{
    internal class BinarySearch
    {
        public static int Search(int[] nums, int target)
        {
            return binarySearch(nums, target, 0, nums.Length - 1);
        }

        private static int binarySearch(int[] nums, int target, int leftPointer, int rightPointer)
        {
            if (leftPointer > rightPointer)
            {
                return -1;
            }
            int mid = (leftPointer + rightPointer) / 2;
            if (target == nums[mid])
            {
                return mid;
            }
            else if (target < nums[mid])
            {
                return binarySearch(nums, target, leftPointer, mid - 1);
            }
            return binarySearch(nums, target, mid + 1, rightPointer);
        }
    }
}
