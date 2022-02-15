using CSharpAlgos.Algorithms;
using CSharpAlgos.Leetcode;

foreach (IList<int> l in Combinations.Combine(4, 2))
{
    Console.WriteLine(l[0].ToString(), l[1].ToString());
}

