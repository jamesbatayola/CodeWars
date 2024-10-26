// Introduction
//
//     The first century spans from the year 1 up to and including the year 100, the second century - from the year 101 up to and including the year 200, etc.
//     Task
//
//     Given a year, return the century it is in.
// Examples
//
// 1705 --> 18
// 1900 --> 19
// 1601 --> 17
// 2000 --> 20
// 2742 --> 28

// Console.WriteLine(CenturyFromYear(1705)); 
// Console.WriteLine(CenturyFromYear(1900)); 
// Console.WriteLine(CenturyFromYear(1601)); 
// Console.WriteLine(CenturyFromYear(2000)); 
// Console.WriteLine(CenturyFromYear(2742)); 

Console.WriteLine(CenturyFromYear(2302)); 

int CenturyFromYear(int year)
{
    return $"{year}"[^1] == '0' && $"{year}"[^2] == '0'
        ? Convert.ToInt32($"{year}".Remove(2, 2))
        : Convert.ToInt32($"{year}".Remove(2, 2)) + 1;
}

Console.ReadLine();