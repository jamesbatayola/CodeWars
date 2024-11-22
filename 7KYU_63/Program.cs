// Write a function partlist that gives all the ways to divide a list (an array) of at least two elements into two non-empty parts.
//
//     Each two non empty parts will be in a pair (or an array for languages without tuples or a structin C - C: see Examples test Cases - )
// Each part will be in a string
//     Elements of a pair must be in the same order as in the original array.
//     Examples of returns in different languages:
// a = ["az", "toto", "picaro", "zone", "kiwi"] -->
//     [["az", "toto picaro zone kiwi"], ["az toto", "picaro zone kiwi"], ["az toto picaro", "zone kiwi"], ["az toto picaro zone", "kiwi"]] 
// or
//     a = {"az", "toto", "picaro", "zone", "kiwi"} -->
// {{"az", "toto picaro zone kiwi"}, {"az toto", "picaro zone kiwi"}, {"az toto picaro", "zone kiwi"}, {"az toto picaro zone", "kiwi"}}
// or
//     a = ["az", "toto", "picaro", "zone", "kiwi"] -->
//         [("az", "toto picaro zone kiwi"), ("az toto", "picaro zone kiwi"), ("az toto picaro", "zone kiwi"), ("az toto picaro zone", "kiwi")]
// or 
//     a = [|"az", "toto", "picaro", "zone", "kiwi"|] -->
//         [("az", "toto picaro zone kiwi"), ("az toto", "picaro zone kiwi"), ("az toto picaro", "zone kiwi"), ("az toto picaro zone", "kiwi")]
// or
//     a = ["az", "toto", "picaro", "zone", "kiwi"] -->
//         "(az, toto picaro zone kiwi)(az toto, picaro zone kiwi)(az toto picaro, zone kiwi)(az toto picaro zone, kiwi)"
// Note
//     You can see other examples for each language in "Your test cases"

static string[][] Partlist(string[] arr)
{
    var result = new string[arr.Length - 1][];
    
    for (int i = 0; i < result.Length; i++)
    {
        var pair = new string[2];

        pair[0] = string.Join(" ", arr.Where((e, x) => x <= i));
        pair[1] = string.Join(" ", arr.Where((e, x) => x > i));
        
        result[i] = pair;
    }

    return result;
}

// make a 2d array with length of arr input minus 1
// 
