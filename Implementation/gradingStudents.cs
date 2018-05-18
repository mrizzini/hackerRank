using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the gradingStudents function below.
     */
    static int[] gradingStudents(int[] grades) {

// If the difference between the grade and the next multiple of 5 is less than 3, round grade up to the next multiple of 5.
        
        int[] array = new int[grades.Length];
        int nextMult;
        int difference;
        
        for (var i = 0; i < grades.Length; i++)
        {
            nextMult = ((grades[i] / 5 + 1) * 5);
            difference = nextMult - grades[i];

            if (grades[i] < 38 || difference >= 3)
            {
                array[i] = grades[i];
            }
            else 
            {
                array[i] = nextMult;
            }
        }
        
        return array;

    }

    
    
    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int [n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++) {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades);

        tw.WriteLine(string.Join("\n", result));

        tw.Flush();
        tw.Close();
    }
}