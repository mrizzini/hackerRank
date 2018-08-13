using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var dates = Console.ReadLine().Split();
        var dates2 = Console.ReadLine().Split();
        
        var dayReturned = int.Parse(dates[0]);
        var monthReturned = int.Parse(dates[1]);
        var yearReturned = int.Parse(dates[2]);

        var dayDue = int.Parse(dates2[0]);
        var monthDue = int.Parse(dates2[1]);
        var yearDue = int.Parse(dates2[2]);
        
        var dayDiff = dayReturned - dayDue;
        var monthDiff = monthReturned - monthDue;
        var yearDiff = yearReturned - yearDue;
        
        int fine;
        
        if (yearDiff == 0)
        {
            if (monthDiff < 0)
            {
                fine = 0;
            }
            else if (monthDiff == 0 && dayDiff <= 0)
            {
                fine = 0;
            }
            else if (monthDiff == 0 && dayDiff > 0)
            {
                fine = 15 * dayDiff;
            }
            else
            {
                fine = 500 * monthDiff;
            }
        }
        else if (yearDiff < 0)
        {
            fine = 0;
        }
        else
        {
            fine = 10000;
        }
        
        Console.WriteLine(fine);

        
//         if (yearReturned < yearDue)
//         {
//             fine = 0;
//         }
        
//         else if (monthReturned < monthDue && yearReturned <= yearDue)
//         {
//             fine = 0;
//         }
        
//         else if (monthReturned > monthDue && yearDue == yearReturned)
//         {
//             fine = (500 * (monthReturned - monthDue));
//         }
        
//         else if (dayReturned <= dayDue && monthReturned == monthDue && yearDue == yearReturned)
//         {
//             fine = (0);
//         }
        
//         else if (dayReturned > dayDue && monthReturned == monthDue && yearDue == yearReturned)
//         {
//             fine = (15 * (dayReturned - dayDue));
//         }
        
//         else
//         {
//             fine = (10000);
//         }
    }
}