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

    // Complete the minimumDistances function below.
    static int minimumDistances(int[] a) {
        
        List<int> mins = new List<int>(); 
        
        for (var i = 0; i < a.Length; i++)
        {
            for (var j = i + 1; j < a.Length; j++)
            {
                // Console.WriteLine("i {0} j {1}", a[i], a[j]);
                if (a[i] == a[j])
                {
                    mins.Add(j - i);                
                }
            }
        }
        
        if (mins.Count == 0)
        {
            return -1;
        }
        
        return mins.Min();

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int result = minimumDistances(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
