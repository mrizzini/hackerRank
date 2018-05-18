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

    // Complete the breakingRecords function below.
    static int[] breakingRecords(int[] score) {
    
    var max = score[0];
    var min = score[0];
    var brokenRecords = new int[2];
    var brokeHighScore = 0;
    var brokeLowScore = 0;

        
    foreach (var gameScore in score)
    {
        if (gameScore > max)
        {
            brokeHighScore++;
            max = gameScore;
        }
        if (gameScore < min)
        {
            brokeLowScore++;
            min = gameScore;
        }
    }

    brokenRecords[0] = brokeHighScore;
    brokenRecords[1] = brokeLowScore;
        
    return brokenRecords;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] score = Array.ConvertAll(Console.ReadLine().Split(' '), scoreTemp => Convert.ToInt32(scoreTemp))
        ;
        int[] result = breakingRecords(score);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
