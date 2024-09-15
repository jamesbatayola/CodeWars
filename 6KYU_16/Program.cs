// Given a string of words, you need to find the highest scoring word.

// Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.

// For example, the score of abad is 8 (1 + 2 + 1 + 4).

// You need to return the highest scoring word as a string.

// If two words score the same, return the word that appears earliest in the original string.

// All letters will be lowercase and all inputs will be valid.

Console.WriteLine(High("man i need a taxi up to ubud"));
//Console.WriteLine(High("what time are we climbing up to the volcano"));
//Console.WriteLine(High("take me to semynak"));

static string High(string s)
{
    var highest = new string[1];

    string[] words = s.Split(" ");

    int length = words.Length + s.Replace(" ", "").Length;

    int res = 0, temp = 0, count = 0, index = 0;

    for (int i = 0; i < length; i++)
    {
        if (index >= words[count].Length)
        {
            if (res < temp) highest[0] = words[count];

            res = res < temp ? temp : res;
            index = 0;
            temp = 0;
            count++;
        }
        else 
            temp += (words[count][index++] - 0) - ('a' - 0) + 1;
    }

    return highest[0];
}