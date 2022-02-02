using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Leetcode
{
    internal class RichestCustomerWealth
    {
        public static int MaximumWealth(int[][] accounts)
        {
            int richest = 0;
            foreach (var account in accounts)
            {
                richest = Math.Max(richest, account.Sum());
            }

            return richest;
        }
    }
}
