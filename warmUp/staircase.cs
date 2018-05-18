using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the staircase function below.
     */
    static void staircase(int n) {
        /*
         * Write your code here.
         */
        
        var spaces = n - 1;
        var hash = 1;
        
        // loops through size of n to get right amount of rows
        for (var i = 0; i < n; i++)
        {
            // prints correct amount of spaces for each row
            for (var j = 0; j < spaces; j++)
            {
                Console.Write(" ");            
            }
            // prints correct amount of #'s for each row
            for (var k = 0; k < hash; k++)
            {
                Console.Write("#");
            }
            spaces--;
            hash++;
            // starts your new row before going throuh next iteration of the i loop
            Console.WriteLine();
        }
        
        // the idea is that no matter what n is, the first loop will print you n - 1 spaces, and           // then one #, and then a new line. The next loop, it will print you n - 2 spaces, and
        // then two ##, and then a new line. We use the spaces and hash variables to keep track
        // of these

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}