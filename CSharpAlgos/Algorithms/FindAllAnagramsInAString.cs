namespace CSharpAlgos.Algorithms
{
    internal class FindAllAnagramsInAString
    {
        public static IList<int> FindAnagrams(string s, string p)
        {
            IList<int> list = new List<int>();
            if (p.Length > s.Length)
            {
                return list;
            }
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in p)
            {
                if (!map.ContainsKey(c))
                {
                    map.Add(c, 0);
                }
                map[c]++;
            }
            int leftPointer = 0, rightPointer = 0, flag = map.Keys.Count;
            while (rightPointer < s.Length)
            {
                char c = s[rightPointer];
                if (map.ContainsKey(c))
                {
                    map[c]--;
                    if (map[c] == 0)
                    {
                        flag--;
                    }
                }
                rightPointer++;
                while (flag == 0)
                {
                    char cc = s[leftPointer];
                    if (map.ContainsKey(cc))
                    {
                        map[cc]++;
                        if (map[cc] > 0)
                        {
                            flag++;
                        }
                    }
                    if (rightPointer - leftPointer == p.Length)
                    {
                        list.Add(leftPointer);
                    }
                    leftPointer++;
                }
            }
            return list;
        }
    }
}
