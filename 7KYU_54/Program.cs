//Write a program to determine if a string contains only unique characters. Return true if it does and false otherwise.

//The string may contain any of the 128 ASCII characters. Characters are case-sensitive, e.g. 'a' and 'A' are considered different characters.


Console.WriteLine(HasUniqueChars("asd"));
Console.WriteLine(HasUniqueChars("asda"));

static bool HasUniqueChars(string str)
{
    return string.Join("", str.Distinct()) == str;
}