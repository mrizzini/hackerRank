using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the miniMaxSum function below.
     */
    static void miniMaxSum(int[] arr) {
        /*
         * Write your code here.
         */
        Int64 sum = 0;
        var sumList = new List<Int64>();

        foreach(var n in arr)
        {
            sum += n;    
        }
                
        for (var i = 0; i < arr.Length; i++)
        {
            sumList.Add(sum - arr[i]);
        }
        
        long min = sumList.Min();
        long max = sumList.Max();
        
        Console.WriteLine(min + " " + max);

    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}