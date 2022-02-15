using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Leetcode
{
    internal class Combinations
    {
        public static IList<IList<int>> Combine(int n, int k)
        {
            IList<IList<int>> res = new List<IList<int>>();
            CombineHelper(res, new List<int>(), 1, n, k);
            return res;
        }

        private static void CombineHelper(IList<IList<int>> res, IList<int> combination, int start, int n, int k)
        {
            if (combination.Count == k)
            {
                res.Add(new List<int>(combination));
            }
            else
            {
                for (int i = start; i <= n; i++)
                {
                    combination.Add(i);
                    CombineHelper(res, combination, i + 1, n, k);
                    combination.Remove(combination.Count - 1);
                }
            }

        }
    }
}
