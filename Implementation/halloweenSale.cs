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

    // Complete the howManyGames function below.
    static int howManyGames(int p, int d, int m, int s) {
        // Return the number of games you can buy
        var currentCost = p;
        var dollarsLeft = s; 
        var discount = d; 
        var cutoff = m; 
        var totalGames = 0;
        
        while (dollarsLeft >= currentCost)
        {
            if (currentCost <= dollarsLeft)
            {
                if (currentCost <= cutoff)
                {
                    currentCost = cutoff;
                    dollarsLeft -= currentCost;
                    totalGames++;
                }
                else
                {
                    dollarsLeft -= currentCost;
                    currentCost -= discount;
                    totalGames++;
                    if (currentCost <= cutoff)
                    {
                        currentCost = cutoff;
                    }
                }
            }
        }
        
        return totalGames;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] pdms = Console.ReadLine().Split(' ');

        int p = Convert.ToInt32(pdms[0]);

        int d = Convert.ToInt32(pdms[1]);

        int m = Convert.ToInt32(pdms[2]);

        int s = Convert.ToInt32(pdms[3]);

        int answer = howManyGames(p, d, m, s);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}
