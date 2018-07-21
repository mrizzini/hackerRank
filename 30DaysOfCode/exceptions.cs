using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string S = Console.ReadLine();
    
        try
        {
          Console.WriteLine(int.Parse(S));  
        }
        catch (Exception FormatException)
        {
            Console.WriteLine("Bad String");
        }
    }
}