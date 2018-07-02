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

    // Complete the marsExploration function below.
    static int marsExploration(string s) {
        
        var counter = 0;
        
        for (int i = 0, j = 0; j < s.Length - 2; i++)
        {
            if (s[j] != 'S')
            {
                counter++;
            }
            if (s[j + 1] != 'O')
            {
                counter++;
            }
            if (s[j + 2] != 'S')
            {
                counter++;
            }    
            
            j += 3;
        }
        
        return counter;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = marsExploration(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
