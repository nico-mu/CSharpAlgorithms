// See https://aka.ms/new-console-template for more information
using CSharpAlgos.Algorithms;

IList<int> res = FindAllAnagramsInAString.FindAnagrams("cbaebabacd", "abc");
Console.WriteLine("Length: " + res.Count);
foreach (int i in res)
{
    Console.WriteLine(i);
}

