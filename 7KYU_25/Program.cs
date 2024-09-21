// using static System.Runtime.InteropServices.JavaScript.JSType;
// Description:

// Create a function named divisors/Divisors that takes an integer n > 1 and returns an array with all of the integer's divisors(except for 1 and the number itself), from smallest to largest. If the number is prime return the string '(integer) is prime' (null in C#, empty table in COBOL) (use Either String a in Haskell and Result<Vec<u32>, String> in Rust).
// Examples:

// divisors(12)-- > [2, 3, 4, 6]
// divisors(25)-- > [5]
// divisors(13)-- > "13 is prime"

var a1 = Divisors(15);
var a2 = Divisors(16);
var a3 = Divisors(253);
var a4 = Divisors(24);

foreach(int i in a1)
    Console.WriteLine(i);

static int[] Divisors(int n)
{
    int[] res = Enumerable.Range(2, n - 2).Where(e => n % e == 0).ToArray();
    return res.Length > 0 ? res : null;
}

Console.ReadLine();