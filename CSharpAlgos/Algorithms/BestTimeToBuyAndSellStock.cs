using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Algorithms
{
    internal class BestTimeToBuyAndSellStock
    {
        public static int MaxProfit(int[] prices)
        {
            int min = int.MaxValue, maxProfit = 0;
            foreach (var price in prices)
            {
                min = Math.Min(min, price);
                maxProfit = Math.Max(maxProfit, price - min);
            }
            return maxProfit;
        }
    }
}
