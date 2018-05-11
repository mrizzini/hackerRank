using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the diagonalDifference function below.
     */
    static int diagonalDifference(int[][] a) {

        var firstSum = 0;
        var secondSum = 0;
        var row = a.Length - 1;
        var arrayLength = a.Length;
        var column = 0;
        
        for (var i = 0; i < arrayLength; i++)
        {
            firstSum += a[i][i];
            secondSum += a[row][column];
            column++;
            row--;
        }
        
        // for (var column = 0; column < arrayLength; column++)
        // {
        //     secondSum += a[row][column];
        //     row--;
        // }
        
        return Math.Abs(firstSum - secondSum);
    }
    


    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[][] a = new int[n][];

        for (int aRowItr = 0; aRowItr < n; aRowItr++) {
            a[aRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        }

        int result = diagonalDifference(a);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
