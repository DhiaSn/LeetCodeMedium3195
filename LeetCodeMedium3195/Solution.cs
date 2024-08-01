using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMedium3195
{
    public static class Solution
    {
        public static int MinimumArea(int[][] grid)
        {
            int minR = int.MaxValue;
            int maxR = int.MinValue;
            int minC = int.MaxValue;
            int maxC = int.MinValue;

            for (int i = 0; i < grid.Length; i++)
                for (int j = 0; j < grid[0].Length; j++)
                    if (grid[i][j] == 1)
                    {
                        minR = Math.Min(minR, i);
                        maxR = Math.Max(maxR, i);
                        minC = Math.Min(minC, j);
                        maxC = Math.Max(maxC, j);
                    }

            return (maxR - minR + 1) * (maxC - minC + 1);
        }
    }
}
