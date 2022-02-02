using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Leetcode
{
    internal class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            return BinarySearch(nums, target, 0, nums.Length - 1);
        }
        private static int BinarySearch(int[] nums, int target, int leftPointer, int rightPointer)
        {
            if (leftPointer > rightPointer)
            {
                return leftPointer;
            }
            int mid = (leftPointer + rightPointer) / 2;
            if (target == nums[mid])
            {
                return mid;
            }
            else if (target < nums[mid])
            {
                return BinarySearch(nums, target, leftPointer, mid - 1);
            }
            return BinarySearch(nums, target, mid + 1, rightPointer);
        }
    }
}
