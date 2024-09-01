using System.Collections.Generic;

namespace _6KYU_03;

// The main idea is to count all the occurring characters in a string. If you have a string like aba, then the result should be {'a': 2, 'b': 1}.

// What if the string is empty? Then the result should be empty object literal, {}

internal class Program
{
    static void Main(string[] args)
    {
        string asd = "aba";

        count(asd);
      
        Console.ReadLine();   
    }
        
    // SOLUTION
    public static Dictionary<char, int> count(string str)
    {
        return str
              .GroupBy(x => x)
              .ToDictionary(x => x.Key, x => x.Count());
    }

}
