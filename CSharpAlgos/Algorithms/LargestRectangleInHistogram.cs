﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Algorithms
{
    internal class LargestRectangleInHistogram
    {
        public static int LargestRectangleArea(int[] heights)
        {
            int n = heights.Length, max = 0;
            var stack = new Stack<int>();
            for (int i = 0; i <= n; i++)
            {
                var height = i < n ? heights[i] : 0;
                while (stack.Count != 0 && heights[stack.Peek()] > height)
                {
                    var currHeight = heights[stack.Pop()];
                    var prevIndex = stack.Count == 0 ? -1 : stack.Peek();
                    max = Math.Max(max, currHeight * (i - 1 - prevIndex));
                }
                stack.Push(i);
            }

            return max;
        }
    }
}
