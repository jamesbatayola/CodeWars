using System.Collections;
using System.Linq;
using System.Numerics;

namespace _8KYU_15;

//Input: Array of elements
//["h", "o", "l", "a"]

//Output: String with comma delimited elements of the array in th same order.

//"h,o,l,a"

//Note: if this seems too simple for you try the next level

//Note2: the input data can be: boolean array, array of objects, array of string arrays, array of number arrays... 😕

internal class Program
{
    static void Main(string[] args)
    {
        object[][] asd1 = { ["hello", "this", "is", "an", "array!"], ['a', 'b', 'c', 'd', 'e'] };
        object[] asd2 = { 2, 4, 5, 2 };

        Console.WriteLine(string.Join(",", asd2));

        Console.ReadLine();
    }

    public static string PrintArray(object[] array)
    {
        return string.Join(",", array.Select(x => x is Object[]? PrintArray(x as object[]) : x));
    }
}


