// Write Number in Expanded Form

// You will be given a number and you will need to return it as a string in Expanded Form. For example:

// expandedForm(12)-- > should return "10 + 2"
// expandedForm(42)-- > should return "40 + 2"
// expandedForm(70304)-- > should return "70000 + 300 + 4"

// NOTE: All numbers will be whole numbers greater than 0.

using System.Text;

Console.WriteLine(ExpandedForm(12));
Console.WriteLine(ExpandedForm(43));
Console.WriteLine(ExpandedForm(70304));

static string ExpandedForm(long num)
{ 
    var digits = num.ToString();
    var sb = new StringBuilder();

    for (int i = 0; i < digits.Length; i++)
    {
        string temp = "";

        temp += digits[i] != '0' && i != digits.Length ? $"{digits[i]} + {new string('0', digits.Length - i + 1)}" :
                                    

        if (digits[i] != '0' && i + 1 != digits.Length)
        {
            temp += 
            //sb.Append(numString[i]);
            //sb.Append('0', numString.Length - (i + 1));
            //sb.Append(" + ");
        }
        else if (digits[i] != '0' && i + 1 == digits.Length)
            sb.Append(digits[i]);
    }

    return sb.ToString();
}

Console.ReadLine();