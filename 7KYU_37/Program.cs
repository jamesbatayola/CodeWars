// Determine the total number of digits in the integer (n>=0) given as input to the function. For example, 9 is a single digit, 66 has 2 digits and 128685 has 6 digits. Be careful to avoid overflows/underflows.

// All inputs will be valid.

Console.WriteLine(Digits(5ul));
Console.WriteLine(Digits(12345ul));
Console.WriteLine(Digits(9876543210ul));

static int Digits(ulong n)
{
    return n.ToString().Count(char.IsDigit);
}

Console.ReadLine();