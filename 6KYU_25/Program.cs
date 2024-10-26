//Complete the solution so that it splits the string into pairs of two characters. If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').

//Examples:

//* 'abc' =>  ['ab', 'c_']
//* 'abcdef' => ['ab', 'cd', 'ef']

//Complete the solution so that it splits the string into pairs of two characters. If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').

//Examples:

//* 'abc' =>  ['ab', 'c_']
//* 'abcdef' => ['ab', 'cd', 'ef']

var test1 = Solution("abc");

foreach(var i in test1)
    Console.WriteLine(i);

static string[] Solution(string str)
{
    var pair = new List<string>();

    for(int i = 0; i < str.Length; i += 2)
    {
        if (str.Length % 2 != 0 && i + 1 == str.Length)
            pair.Add(string.Concat(str[i], "_"));
        else
            pair.Add(string.Concat(str[i], str[i+1]));
    }

    return pair.ToArray();
}

Console.ReadLine();