using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {

        Dictionary<string, string> PhoneBook = new Dictionary<string, string>();        
        int n = Convert.ToInt32(Console.ReadLine());
        String name;

        for (var i = 0; i < n; i++)
        {
            var entries = Console.ReadLine().Split(' ');
            PhoneBook.Add(entries[0], entries[1]);
        }
    
        while ((name = Console.ReadLine()) != null)
        {
            if (PhoneBook.ContainsKey(name))
                {
                    Console.WriteLine(name + "=" + PhoneBook[name]);
                }
            else
            {
                Console.WriteLine("Not found");
            }
        }

    }
}