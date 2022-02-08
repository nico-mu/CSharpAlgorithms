using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Leetcode
{
    internal class MaxAreaOfIsland
    {
        public static int SolveMaxAreaOfIsland(int[][] grid)
        {
            int result = 0;
            for (int y = 0; y < grid.Length; y++)
            {
                for (int x = 0; x < grid[0].Length; x++)
                {
                    if (grid[y][x] == 1)
                    {
                        result = Math.Max(result, MaxArea(grid, x, y));
                    }
                }
            }
            return result;
        }

        public static int MaxArea(int[][] grid, int x, int y)
        {
            if (x < 0 || y < 0 || y >= grid.Length || x >= grid[0].Length || grid[y][x] != 1)
            {
                return 0;
            }
            else
            {
                grid[y][x] = 0;
                return 1 + MaxArea(grid, x + 1, y) + MaxArea(grid, x - 1, y) + MaxArea(grid, x, y + 1) + MaxArea(grid, x, y - 1);
            }

        }
    }
}
