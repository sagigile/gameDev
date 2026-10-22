using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'formingMagicSquare' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY s as parameter.
     */

    public static int formingMagicSquare(List<List<int>> s)
    {
        int[][][] magicSquares = new int[][][]
        {
            new int[][] { new[] { 8, 1, 6 }, new[] { 3, 5, 7 }, new[] { 4, 9, 2 } },
            new int[][] { new[] { 6, 1, 8 }, new[] { 7, 5, 3 }, new[] { 2, 9, 4 } },
            new int[][] { new[] { 4, 9, 2 }, new[] { 3, 5, 7 }, new[] { 8, 1, 6 } },
            new int[][] { new[] { 2, 9, 4 }, new[] { 7, 5, 3 }, new[] { 6, 1, 8 } },
            new int[][] { new[] { 8, 3, 4 }, new[] { 1, 5, 9 }, new[] { 6, 7, 2 } },
            new int[][] { new[] { 4, 3, 8 }, new[] { 9, 5, 1 }, new[] { 2, 7, 6 } },
            new int[][] { new[] { 6, 7, 2 }, new[] { 1, 5, 9 }, new[] { 8, 3, 4 } },
            new int[][] { new[] { 2, 7, 6 }, new[] { 9, 5, 1 }, new[] { 4, 3, 8 } }
        };

        int best = int.MaxValue;
        foreach (int[][] m in magicSquares)
        {
            int cost = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cost += Math.Abs(s[i][j] - m[i][j]);
                }
            }
            best = Math.Min(best, cost);
        }
        return best;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<List<int>> s = new List<List<int>>();

        for (int i = 0; i < 3; i++)
        {
            s.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList());
        }

        int result = Result.formingMagicSquare(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
