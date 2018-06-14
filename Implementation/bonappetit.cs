using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution {
class Solution {
    static void Main(string[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT */
        var line1 = System.Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        var line2 = System.Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        var line3 = int.Parse(System.Console.ReadLine().Trim()); 
        var originalTotal = 0;
        var totalMinusAnna = 0;

        foreach (var foodItem in line2)
        {
            originalTotal += foodItem;
        }
        
        line2.RemoveAt(line1[1]);
        
        foreach(var foodItem in line2)
        {
            totalMinusAnna += foodItem;
        }
        
        if ((totalMinusAnna / 2) == line3)
        {
            Console.WriteLine("Bon Appetit");
        } 
        else
        {
            Console.WriteLine(line3 - (totalMinusAnna / 2));    
        }
        
    }
}
}