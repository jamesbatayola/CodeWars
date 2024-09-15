// Instructions
// Write a function that takes a single non-empty string of only lowercase and uppercase ascii letters (word) as its argument, and returns an ordered list containing the indices of all capital (uppercase) letters in the string.

// Example (Input --> Output)
// "CodEWaRs" --> [0,3,4,6]nstructions
// Write a function that takes a single non-empty string of only lowercase and uppercase ascii letters (word) as its argument, and returns an ordered list containing the indices of all capital (uppercase) letters in the string.

// Example (Input --> Output)
// "CodEWaRs" --> [0,3,4,6]

var asd = Capitals("CodEWaRs"); 

foreach(var i  in asd)
    Console.WriteLine(i);

// SOLUTION
static int[] Capitals(string word)
{
    var res = new List<int>();

    for(int i = 0; i < word.Length; i++)
    {
        if (char.IsUpper(word[i])) res.Add(i);
    }

    return res.ToArray();
}

Console.ReadLine();