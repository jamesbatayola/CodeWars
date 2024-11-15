//Create a function taking a positive integer between 1 and 3999 (both included) as its parameter and returning a string containing the Roman Numeral representation of that integer.

//Modern Roman numerals are written by expressing each digit separately starting with the leftmost digit and skipping any digit with a value of zero. There cannot be more than 3 identical symbols in a row.

//In Roman numerals:

//    1990 is rendered: 1000 = M + 900 = CM + 90 = XC; resulting in MCMXC.
//    2008 is written as 2000=MM, 8=VIII; or MMVIII.
//    1666 uses each Roman symbol in descending order: MDCLXVI.

//Example:

//   1-- > "I"
//1000-- > "M"
//1666-- > "MDCLXVI"

//Help:

//Symbol Value
//I          1
//V          5
//X          10
//L          50
//C          100
//D          500
//M          1,000

Console.WriteLine(Solution(1));
Console.WriteLine(Solution(2));
Console.WriteLine(Solution(4));
Console.WriteLine(Solution(500));
Console.WriteLine(Solution(1000));
Console.WriteLine(Solution(1954));
Console.WriteLine(Solution(1990));
Console.WriteLine(Solution(2008));
Console.WriteLine(Solution(2014));

Console.WriteLine(Solution(45));

static string Solution(int n)
{
    string result = "";

    var dict = new Dictionary<int, char>()
    {
        { 1, 'I' },
        { 5, 'V' },
        { 10, 'X' },
        { 50, 'L' },
        { 100, 'C' },
        { 500, 'D' },
        { 1000, 'M' }
    };

    int[] asd = [1000, 500, 100, 50, 10, 5, 1];

    string yearString = n.ToString();

    int yearSubstring = yearString[0] - '0';

    for (int i = 0; i < asd.Length; i++)
    {
        yearSubstring = yearString.Substring(0).Length > 1 ?
            int.Parse($"{yearString[0]}" + new string('0', yearString.Length - 1)) :
            int.Parse(string.Join("", yearString.Where(e => e != 0)));

        if (yearString[0] == '0')
        {
            continue;
        }

        if (asd[i] <= yearSubstring)
        {
            if ((yearString[0] - '0') + 1 == 10 || (yearString[0] - '0') + 1 == 5)
            {
                result += yearSubstring switch
                {
                    900 => "CM",
                    400 => "CD",
                    90 => "XC",
                    40 => "XL",
                    9 => "IX",
                    4 => "IV",
                    _ => ""
                };

                if (i < asd.Length - 1) i++;
            }
            else
            {
                result += new string(dict[asd[i]], yearSubstring / asd[i]);
            }

            yearString = yearSubstring / asd[i] == 1 ?
              $"{int.Parse(yearString) - asd[i]}" :
              $"{int.Parse(yearString) - yearSubstring}";
        }
    }

    return result;
}

// UNFINISHED