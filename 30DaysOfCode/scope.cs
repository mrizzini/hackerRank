using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;
    
    // Add your code here

    public Difference(int[] Elements)
    {
        this.elements = Elements;
    }

    public int computeDifference()
    {
        int placeHolder = 0;
        maximumDifference = 0;
        for (var i = 0; i < elements.Length; i++)
        {
            for (var j = 1; j < elements.Length; j++)
            {
                if (placeHolder > maximumDifference)
                {
                    maximumDifference = placeHolder;
                }
                placeHolder = Math.Abs(elements[i] - elements[j]);    
            }
        }
        
        return maximumDifference;
    }
    
} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}