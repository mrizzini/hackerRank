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

    // Complete the pangrams function below.
    static string pangrams(string s) {
        
        var asciiUpper = 'A';
        var asciiLower = 'a';
        var counter = 0;

        for (var i = 0; i < 26; i++)
        {
            if (s.Contains(asciiUpper)) 
            {
                counter++;
                Console.WriteLine(asciiUpper);
            }
            else if (s.Contains(asciiLower))
            {
                counter++;
                Console.WriteLine(asciiLower); 
            }
            asciiUpper++;
            asciiLower++;
        }
        
        if (counter == 26)
        {
            return "pangram";
        }
        else
        {
            return "not pangram";
        }

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
