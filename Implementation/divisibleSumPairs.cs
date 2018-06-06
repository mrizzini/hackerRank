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

class Solution {

    // Complete the divisibleSumPairs function below.
    static int divisibleSumPairs(int n, int k, int[] ar) {
        // list to store the sums
        List<int> sums = new List<int>(); 
        
        // int to store counter of valid numbers divisible by k
        var valids = 0;
        
        // nested loop to add all combinations in array
        for (var i = 0; i < ar.Length; i++)
        {
            for (var j = i + 1; j < ar.Length; j++)
            {
                sums.Add(ar[i] + ar[j]);
            }
        }
        
        // increment counter variable if any number in our sums list is divisible by k
        for (var i = 0; i < sums.Count; i++)
        {
            if (sums[i] % k == 0)
            {
                valids++;
            }
        }
        
        return valids;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = divisibleSumPairs(n, k, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}