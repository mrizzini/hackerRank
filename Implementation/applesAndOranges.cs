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

    // Complete the countApplesAndOranges function below.
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
        
        var appleTreePosition = a;
        var appleCounter = 0; 
        var orangeTreePosition = b;
        var orangeCounter = 0;

        // APPLE LOGIC

        foreach(var apple in apples)
        {
            if (apple + appleTreePosition >= s && apple + appleTreePosition <= t)
//             if (samsHouse.Contains(apple + appleTreePosition))
            {
                appleCounter++;
            }
        }

        
        // ORANGE LOGIC
  
        foreach (var orange in oranges)
        {
            if (orange + orangeTreePosition >= s && orange + orangeTreePosition <= t)
              // if (samsHouse.Contains(orange + orangeTreePosition))
            {
                orangeCounter++;
            }         
        }
        
        Console.WriteLine(appleCounter);                          
        Console.WriteLine(orangeCounter);
        
        
        var applecounter = 0;
        var orangecounter = 0;
    
        oranges.forEach(function(orange){
            if (b + (orange) >= s && b + (orange) <= t ) {
                orangecounter++;
            }
        });
    
        apples.forEach(function(apple){
            if (a + (apple) >= s && a + (apple) <= t ) {
                applecounter++;     
            }
            });
    
        console.log(applecounter);
        console.log(orangecounter);
    }

    static void Main(string[] args) {
        string[] st = Console.ReadLine().Split(' ');

        int s = Convert.ToInt32(st[0]);

        int t = Convert.ToInt32(st[1]);

        string[] ab = Console.ReadLine().Split(' ');

        int a = Convert.ToInt32(ab[0]);

        int b = Convert.ToInt32(ab[1]);

        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        int[] apple = Array.ConvertAll(Console.ReadLine().Split(' '), appleTemp => Convert.ToInt32(appleTemp))
        ;

        int[] orange = Array.ConvertAll(Console.ReadLine().Split(' '), orangeTemp => Convert.ToInt32(orangeTemp))
        ;
        countApplesAndOranges(s, t, a, b, apple, orange);
    }
}
