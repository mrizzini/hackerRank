using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    
    static void swap(ref int a, ref int b)
    {
        int place = a;
        a = b;
        b = place;
    }

    static void Main(String[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        
        // Write Your Code Here
        int numberOfSwaps = 0;
        int placeHolder;

        for (int i = 0; i < n; i++) 
        {
            // Track number of elements swapped during a single array traversal
            for (int j = 0; j < n - 1; j++) {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1]) {
                    swap(ref a[j], ref a[j + 1]);
                    // placeHolder = a[j];
                    // a[j] = a[j + 1];
                    // a[j + 1] = placeHolder;
                    numberOfSwaps++;
                }
            }

            // If no elements were swapped during a traversal, array is sorted
            if (numberOfSwaps == 0) {
                break;
            }
        }
        
        int firstE = a[0];
        int lastE = a[a.Length - 1];
        
        Console.WriteLine("Array is sorted in {0} swaps.", numberOfSwaps);
        Console.WriteLine("First Element: {0}", firstE);
        Console.WriteLine("Last Element: {0}", lastE);

    }
    
}