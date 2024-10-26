using Microsoft.VisualBasic;
using System.Collections;

namespace _6KYU_07;

// Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements with the same value next to each other and preserving the original order of elements.
// For example:

// uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
// uniqueInOrder("ABBCcAD") == { 'A', 'B', 'C', 'c', 'A', 'D'}
// uniqueInOrder([1, 2, 2, 3, 3]) == { 1,2,3}

internal class Program
{
    static void Main(string[] args)
    {
        var asd = UniqueInOrder("AABBCDdEEEE");

        foreach(var i in asd)
            Console.WriteLine(i);

        Console.ReadLine();
    }

    // SOLUTION
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        //your code here...
        if (iterable.Count() <= 0) return iterable;

        List<T> list = new List<T>(iterable);
        var emptyList = new List<T>();

        // INITIAL VALUE
        var ini = list[0];
        emptyList.Add(ini);

        for (int i = 1; i < list.Count(); i++)
        {
            if (!EqualityComparer<T>.Default.Equals(ini, list[i]))
            {
                ini = list[i];
                emptyList.Add(ini);
            }
        }

        return emptyList;           
    }

    // OTHER ANSWER -----------------------------
    public static IEnumerable<T> _UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        var retList = new List<T>();
        foreach (var element in iterable) if (!element.Equals(retList.LastOrDefault())) retList.Add(element);
        return retList;
    }

}
