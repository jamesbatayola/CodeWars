// Write a function that takes in a string of one or more words, and returns the same string, but with all words that have five or more letters reversed (Just like the name of this Kata). Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.

// Examples:

// "Hey fellow warriors"-- > "Hey wollef sroirraw"
// "This is a test        --> "This is a test" 
// "This is another test"-- > "This is rehtona test"

using System.Text;

//var asd = "asd".Reverse();
//Console.WriteLine(string.Join("", asd));

Console.WriteLine(SpinWords("Hey fellow warriors"));
Console.WriteLine(SpinWords("This is a test"));
Console.WriteLine(SpinWords("This is another test"));
Console.WriteLine(SpinWords("You are almost to the last test"));
Console.WriteLine(SpinWords("Just kidding there is still one more"));

static string SpinWords(string sentence)
{
    StringBuilder sb = new StringBuilder();

    string[] words = sentence.Split(" ");

    for(int i = 0; i < words.Length; i++)
    {
        if (words[i].Length < 5) sb.Append(words[i]);
        else sb.Append(string.Join("", words[i].Reverse()));

        if(i+1 != words.Length) sb.Append(" ");
    }

    return sb.ToString();
}

// OTHER ANSWERS ----------------

static string _SpinWords(string sentence)
{
    return String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
}

Console.ReadLine();