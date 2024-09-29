// Very simple, given a number (integer / decimal / both depending on the language), find its opposite (additive inverse).

// Examples:

// 1: -1
// 14: -14
// - 34: 34

Console.WriteLine(Opposite(1));
Console.WriteLine(Opposite(14));
Console.WriteLine(Opposite(-34));

static int Opposite(int number)
{
    return number < 0 ? Math.Abs(number) : number * -1;
}

Console.ReadLine();