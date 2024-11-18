//Digital root is the recursive sum of all the digits in a number.

//Given n, take the sum of the digits of n. If that value has more than one digit, continue reducing in this way until a single-digit number is produced. The input will be a non-negative integer.

//Examples
//    16  -->  1 + 6 = 7
//   942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
//132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
//493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2

Console.WriteLine(DigitalRoot(16));
Console.WriteLine(DigitalRoot(942));
Console.WriteLine(DigitalRoot(132189));
Console.WriteLine(DigitalRoot(493193));

Console.WriteLine(DigitalRoot(0)); 
Console.WriteLine(DigitalRoot(10)); 
Console.WriteLine(DigitalRoot(16)); 
Console.WriteLine(DigitalRoot(195)); 
Console.WriteLine(DigitalRoot(992)); 
Console.WriteLine(DigitalRoot(167346)); 
Console.WriteLine(DigitalRoot(999999999999)); 


static int DigitalRoot(long n)
{
    if (n < 10)
        return (int) n;

    n = n.ToString().Select(e => e - '0').Sum();

    return DigitalRoot(n);
}