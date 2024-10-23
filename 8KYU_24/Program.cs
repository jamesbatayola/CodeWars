//Write a function to convert a name into initials. This kata strictly takes two words with one space in between them.

//The output should be two capital letters with a dot separating them.

//It should look like this:

//Sam Harris => S.H

//patrick feeney => P.F

Console.WriteLine(AbbrevName("Sam Harris"));
Console.WriteLine(AbbrevName("patrick feeney"));

static string AbbrevName(string name)
{
    return string.Join('.', name.Split(' ').Select(e => char.ToUpper(e[0])));
}

Console.ReadLine();