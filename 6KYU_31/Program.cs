// Write an algorithm that will identify valid IPv4 addresses in dot-decimal format. IPs should be considered valid if they consist of four octets, with values between 0 and 255, inclusive.
// Valid inputs examples:

// Examples of valid inputs:
// 1.2.3.4
// 123.45.67.89

// Invalid input examples:

// 1.2.3
// 1.2.3.4.5
// 123.456.78.90
// 123.045.067.089

// Notes:

// Leading zeros(e.g. 01.02.03.04) are considered invalid
// Inputs are guaranteed to be a single string


//// VALID
Console.WriteLine(IsValidIp("0.0.0.0"));
Console.WriteLine(IsValidIp("1.2.3.4"));
Console.WriteLine(IsValidIp("12.255.56.1"));
Console.WriteLine(IsValidIp("123.45.67.89"));

////// INVALID
Console.WriteLine(IsValidIp("a.b.c.d"));
Console.WriteLine(IsValidIp("1.2.3"));
Console.WriteLine(IsValidIp("1.2.3.4.5"));
Console.WriteLine(IsValidIp("123.456.78.90"));
Console.WriteLine(IsValidIp("123.045.067.089"));
Console.WriteLine(IsValidIp("abc.def.ghi.jkl"));
Console.WriteLine(IsValidIp("123.456.789.0"));
Console.WriteLine(IsValidIp("12.34.56.78sf"));
Console.WriteLine(IsValidIp("12.34.56.-1"));
Console.WriteLine(IsValidIp("12.34.56 .1"));
Console.WriteLine(IsValidIp("pr12.34.56.78"));
Console.WriteLine(IsValidIp("1234.34.56"));

static bool IsValidIp(string ipAddres)
{
    string[] ip = ipAddres.Split('.');

    if (ip.Length != 4 || ip.Any(string.IsNullOrEmpty)) return false;

    bool isValid = true;

    for(int i = 0; i < ip.Length; i++)
    {
        //if (ip[i].All(char.INu))
        for(int j = 0; j < ip[i].Length; j++)
        {
            if (!char.IsDigit(ip[i][j])) return false;
        }
        if (int.Parse(ip[i]) < 0 || int.Parse(ip[i]) > 255)
            isValid = false;
        if (ip[i].Length > 1 &&  ip[i][0] == '0')
            isValid = false;
    }

    return isValid;
}

Console.ReadLine();