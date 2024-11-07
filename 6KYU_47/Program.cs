// Description:
//
// A bookseller has lots of books classified in 26 categories labeled A, B, ... Z. Each book has a code c with randomized sizes of characters. The 1st character of a code is a capital letter which defines the book category.
//
//     In the bookseller's stocklist each code c is followed by a space and by a positive integer n (int n >= 0) which indicates the quantity of books of this code in stock.
//
//     For example an extract of a stocklist could be:
//
// L = {"ABART 20", "CDXEF 50", "BKWRK 25", "BTSQZ 89", "DRTYM 60"}.
// or
//     L = ["ABART 20", "CDXEF 50", "BKWRK 25", "BTSQZ 89", "DRTYM 60"] or ....
//
//     You will be given a stocklist (e.g. : L) and a list of categories in capital letters e.g :
//
// M = {"A", "B", "C", "W"} 
// or
//     M = ["A", "B", "C", "W"] or ...
//
// and your task is to find all the books of L with codes belonging to each category of M and to sum their quantity according to each category.
//
//     For the lists L and M of example you have to return the string (in Haskell/Clojure/Racket/Prolog a list of pairs):
//
// (A : 20) - (B : 114) - (C : 50) - (W : 0)
//
// where A, B, C, W are the categories, 20 is the sum of the unique book of category A, 114 the sum corresponding to "BKWRK" and "BTSQZ", 50 corresponding to "CDXEF" and 0 to category 'W' since there are no code beginning with W.
//
//     If L or M are empty return string is "" (Clojure/Racket/Prolog should return an empty array/list instead).
// Notes:
//
// In the result codes and their values are in the same order as in M.
//     See "Samples Tests" for the return.

var art = new string[] {"ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600"};
var cd = new String[] {"A", "B"};

Console.WriteLine(stockSummary(art, cd));


static string stockSummary(String[] lstOfArt, String[] lstOf1stLetter)
{
    if (lstOfArt.Length <= 0 || lstOf1stLetter.Length <= 0)
        return string.Empty;
    
    var dict = new Dictionary<string, int>();
    
    string[] codeLetters = lstOf1stLetter;

    foreach (var category in codeLetters)
    {
        dict[category] = 0;
    }

    foreach (var code in lstOfArt)
    {
        string[] eachCode = code.Split(' ');

        string firstLetter = $"{eachCode[0][0]}";
        
        if (dict.ContainsKey(firstLetter))
        {
            dict[firstLetter] += int.Parse(eachCode[1]);
        }
    }

    string[] res = new string[dict.Count];

    for (int i = 0; i < res.Length; i++)
    {
        res[i] = $"({codeLetters[i].ToUpper()} : {dict[codeLetters[i]]})";
    }

    return string.Join(" - ", res);
}