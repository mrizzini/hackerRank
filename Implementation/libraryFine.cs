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

    // Complete the libraryFine function below.
    static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2) {
        
        // 9 7 2015 returned in July
        // 6 6 2015 due in June
        
        // 6 6 2015 returned in 2015
        // 9 6 2016 due in 2016
        
        // 2 6 2014 returned june 2, 2014
        // 5 7 2014 due july 5th, 2014
        
        // 28 2 2015 returned feb 28, 2015
        // 15 4 2015 due april 15, 2015
        
        
        var dayDiff = d1 - d2;
        var monthDiff = m1 - m2;
        var yearDiff = y1 - y2;

        if (yearDiff == 0)
        {
            if (monthDiff < 0)
            {
                return 0;
            }
            else if (monthDiff == 0 && dayDiff <= 0)
            {
                return 0;
            }
            else if (monthDiff == 0 && dayDiff > 0)
            {
                return 15 * dayDiff;
            }
            else
            {
                return 500 * monthDiff;            
            }
        }
        else if (yearDiff < 0)
        {
            return 0;
        }
        
        return 10000;
        
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] d1M1Y1 = Console.ReadLine().Split(' ');

        int d1 = Convert.ToInt32(d1M1Y1[0]);

        int m1 = Convert.ToInt32(d1M1Y1[1]);

        int y1 = Convert.ToInt32(d1M1Y1[2]);

        string[] d2M2Y2 = Console.ReadLine().Split(' ');

        int d2 = Convert.ToInt32(d2M2Y2[0]);

        int m2 = Convert.ToInt32(d2M2Y2[1]);

        int y2 = Convert.ToInt32(d2M2Y2[2]);

        int result = libraryFine(d1, m1, y1, d2, m2, y2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
