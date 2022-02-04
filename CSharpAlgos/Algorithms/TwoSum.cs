using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Algorithms
{
    internal class TwoSum
    {
        public static int[] TwoSumSol(int[] numbers, int target)
        {

            int n = numbers.Length;
            int lPointer = 0, rightPointer = n - 1;
            while (lPointer < n && rightPointer < n)
            {
                int leftNumber = numbers[lPointer];
                int rightNumber = numbers[rightPointer];
                if (leftNumber + rightNumber == target)
                {
                    return new int[] { lPointer + 1, rightPointer + 1 };
                }
                else if (leftNumber + rightNumber > target)
                {
                    rightPointer--;
                }
                else if (leftNumber + rightNumber < target)
                {
                    lPointer++;
                }
            }
            return new int[] { };
        }
    }
}
