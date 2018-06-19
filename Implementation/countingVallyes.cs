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
    
//     UDDDUDUU

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s) {
        
        var start = 0;
        var counter = 0;
        var belowZero = false;
        var groundLevel = false;

        foreach (var step in s)
        {
            if (step == 'U')
            {
                start++;
                if (start == 0)
                {
                    groundLevel = true;
                }
            } 
            else
            {
                start--;
                if (start < 0)
                {
                    belowZero = true;
                }
            }
            
            if (belowZero && groundLevel)
            {
                counter++;
                belowZero = false;
                groundLevel = false;
            }
        }
        
        return counter;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}