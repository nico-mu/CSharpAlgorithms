using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos.Algorithms
{
    internal class FloodFill
    {
        public static int[][] SolveFloodFill(int[][] image, int sr, int sc, int newColor)
        {
            if (image[sr][sc] == newColor)
            {
                return image;
            }
            fill(image, sr, sc, newColor, image[sr][sc]);
            return image;
        }

        private static void fill(int[][] image, int sr, int sc, int newColor, int colorToFill)
        {
            if (sr < 0 || sc < 0 || sr >= image.Length || sc >= image[0].Length || image[sr][sc] != colorToFill)
            {
                return;
            }
            image[sr][sc] = newColor;
            fill(image, sr + 1, sc, newColor, colorToFill);
            fill(image, sr - 1, sc, newColor, colorToFill);
            fill(image, sr, sc + 1, newColor, colorToFill);
            fill(image, sr, sc - 1, newColor, colorToFill);
        }
    }
}
