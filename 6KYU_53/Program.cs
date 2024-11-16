//Define a function that takes an integer argument and returns a logical value true or false depending on if the integer is a prime.

//Per Wikipedia, a prime number ( or a prime ) is a natural number greater than 1 that has no positive divisors other than 1 and itself.
//Requirements

//    You can assume you will be given an integer input.
//    You can not assume that the integer will be only positive. You may be given negative numbers as well ( or 0 ).
//    NOTE on performance: There are no fancy optimizations required, but still the most trivial solutions might time out. Numbers go up to 2^31 ( or similar, depending on language ). Looping all the way up to n, or n/2, will be too slow.

//Example

//is_prime(1)  /* false */
//is_prime(2)  /* true  */
//is_prime(-1) /* false */

using System.ComponentModel.DataAnnotations;

Console.WriteLine(IsPrime(0));
Console.WriteLine(IsPrime(1));
Console.WriteLine(IsPrime(2));
Console.WriteLine(IsPrime(-1));

// TRUE
Console.WriteLine(IsPrime(5));
Console.WriteLine(IsPrime(13));
Console.WriteLine(IsPrime(17));
Console.WriteLine(IsPrime(19));
Console.WriteLine(IsPrime(23));

//Console.WriteLine(IsPrime(5));

//var asd = Enumerable.Range(1, 1);

//foreach(var i in asd)
//    Console.WriteLine(i);

//static bool IsPrime(int n)
//{
//    int val = 1;

//    if (n <= 1)
//        return false;

//    for (int i = 2; i <= n; i++)
//        val += n % i == 0 ? 1 : 0;

//    return val == 2;
//}

static bool IsPrime(int n)
{
    if (n <= 1)
        return false;

    var res = new List<int>() { 1, n };

    for(int i = 2; i < n; i++)
    {
        if (n % i == 0)
            return false;
    }

    return res[0] == 1 && res[1] == n; 
}