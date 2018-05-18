using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the birthdayCakeCandles function below.
     */
    static int birthdayCakeCandles(int n, int[] ar) {
 
        var count = 0;
        // var maxHeight = ar[0];
        // foreach (var candle in ar)
        // {
        //     if (candle > maxHeight)
        //     {
        //         maxHeight = candle;
        //     }
        // }
        
        // OR
        
        var maxHeight = ar.Max();
        
        foreach (var candle in ar)
        {
            if (candle == maxHeight)
            {
                count++;
            }
        }
        
        return count;

    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = birthdayCakeCandles(n, ar);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}