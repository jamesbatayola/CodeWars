// Description:
// Implement a pseudo - encryption algorithm which given a string S and an integer N concatenates all the odd-indexed characters of S with all the even-indexed characters of S, this process should be repeated N times.

// Examples:

// encrypt("012345", 1)  =>  "135024"
// encrypt("012345", 2)  =>  "135024"->  "304152"
// encrypt("012345", 3)  =>  "135024"->  "304152"->  "012345"

// encrypt("01234", 1)  =>  "13024"
// encrypt("01234", 2)  =>  "13024"->  "32104"
// encrypt("01234", 3)  =>  "13024"->  "32104"->  "20314"
// Together with the encryption function, you should also implement a decryption function which reverses the process.

// If the string S is an empty value or the integer N is not positive, return the first argument without changes.

// This kata is part of the Simple Encryption Series:

// Simple Encryption #1 - Alternating Split
// Simple Encryption #2 - Index-Difference
// Simple Encryption #3 - Turn The Bits Around
// Simple Encryption #4 - Qwerty
// Have fun coding it and please don't forget to vote and rank this kata! :-)

Console.WriteLine(Encrypt("This is a test!", 1));
Console.WriteLine(Encrypt("This is a test!", 2));
Console.WriteLine(Encrypt("This is a test!", 3));

//Console.WriteLine();

Console.WriteLine(Decrypt("hsi  etTi sats!", 1));
Console.WriteLine(Decrypt("s eT ashi tist!", 2));
Console.WriteLine(Decrypt(" Tah itse sits!", 3));


static string Encrypt(string text, int n)
{
    if (text == null) return null;

    var nums = new List<string>() { text };
    for (int i = 0; i < n; i++)
    {
        string odd = string.Join("", nums[i].Where((x, i) => i % 2 != 0));
        string even = string.Join("", nums[i].Where((x, i) => i % 2 == 0));
        nums.Add(odd + even);
    }
    return nums[^1];
}

static string Decrypt(string encryptedText, int n)
{
    if (encryptedText == null) return null;
    else if (encryptedText == null || n <= 0) return encryptedText;

    int textLength = encryptedText.Length;
    var revList = new List<string>() { encryptedText };
    int half = textLength / 2;

    int oddCount = 0, evenCount = 0, revCount = 0;

    while(n > 0)
    {
        string odd = string.Join("", revList[revCount].Where((x, i) => i < half));
        string even = string.Join("", revList[revCount].Where((x, i) => i >= half));

        char[] temp = new char[textLength];

        for (int i = 0; i < textLength; i++)
        {
            if (i % 2 == 0) temp[i] = even[evenCount++];
            else temp[i] = odd[oddCount++];
        }

        revList.Add(string.Join("", temp));
        revCount++;
        oddCount = 0;
        evenCount = 0;
        n--;
    }

    return revList[^1];
}

// OTHER ANSWER -----------------

static string _Encrypt(string text, int n)
{
    if (string.IsNullOrWhiteSpace(text) || n <= 0)
    {
        return text;
    }

    while (n != 0)
    {
        text = string.Concat(text.Where((c, i) => i % 2 == 1).Concat(text.Where((c, i) => i % 2 == 0)));

        n--;
    }

    return text;
}

static string _Decrypt(string text, int n)
{
    if (string.IsNullOrWhiteSpace(text) || n <= 0)
    {
        return text;
    }

    while (n != 0)
    {
        string leftPart = string.Concat(text.Take(text.Length / 2));
        string rightPart = string.Concat(text.Skip(text.Length / 2));

        text = string.Concat(Enumerable.Range(0, text.Length).Select(i => i % 2 == 0 ? rightPart[i / 2] : leftPart[i / 2]));

        n--;
    }

    return text;
}


Console.ReadLine();