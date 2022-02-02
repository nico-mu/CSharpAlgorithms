using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Leetcode
{
    internal class FirstBadItem
    {
        public static int FirstBadVersion(int n)
        {
            if (n < 2)
            {
                return n;
            }
            return binarySearch(0, n);
        }
        private static int binarySearch(int leftPointer, int rightPointer)
        {
            if (leftPointer > rightPointer)
            {
                return leftPointer;
            }
            int mid = leftPointer + (rightPointer - leftPointer) / 2;
            if (mid != 1)
            {
                return binarySearch(mid + 1, rightPointer);
            }
            return binarySearch(leftPointer, mid - 1);
        }
    }
}
