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

    // Complete the findDigits function below.
    static int findDigits(int n) {

        int counter = 0;
        var currentNumber = n;
        
        List<int> digits = new List<int>();
        while (currentNumber !=0)
        {
            digits.Add(currentNumber % 10);
            currentNumber = currentNumber / 10;
        }
        digits.Reverse();
        
        foreach (var dig in digits)
        {
            if (dig != 0)
            {
                if (n % dig == 0)
                {
                    counter++;
                }
            }

        }
        
        return counter;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = findDigits(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
