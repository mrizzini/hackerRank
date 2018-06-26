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

    // Complete the solve function below.
    static string solve(int year) {
        
        var leapYear = "12.09." + year.ToString();
        var nonLeapYear = "13.09." + year.ToString();
        var year1918 = "26.09." + year.ToString();

        if (year <= 1917)
        {
            if (year % 4 == 0)
            {
                return leapYear;
            }
            else
            {
                return nonLeapYear;
            }
        }
        else if (year >= 1919)
        {
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                {
                    return leapYear;
                }
            else
            {
                return nonLeapYear;
            }
        }
        return year1918;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine());

        string result = solve(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
