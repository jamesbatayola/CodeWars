// Description:
// Introduction

// The ragbaby cipher is a substitution cipher that encodes/decodes a text using a keyed alphabet and their position in the plaintext word they are a part of.

// To encrypt the text This is an example. with the key cipher, first construct a keyed alphabet:

// c i    p    h    e    r    a    b    d    f    g    j    k    l    m    n    o    q    s    t    u    v    w    x    y    z

// Then, number the letters in the text as follows:

// T h    i    s         i    s         a    n         e    x    a    m    p    l    e    .
// 1    2    3    4         1    2         1    2         1    2    3    4    5    6    7     

// To obtain the encoded text, replace each character of the word with the letter in the keyed alphabet the corresponding number of places to the right of it (wrapping if necessary). Non-alphabetic characters are preserved to mark word boundaries.

// Our ciphertext is then Urew pu bq rzfsbtj.
// Task

// Wirate functions encode and decode which accept 2 parameters:

//    text - string - a text to encode/decode
//    key - string - a key

// Notes

//    handle lower and upper case in text string
//    key consists of only lowercase characters

using System.Text;

// ENCODE
Console.WriteLine("ENCODE -------------------------");
Console.WriteLine(Encode("cipher", "cipherabdfgjklmnoqstuvwxyz"));
Console.WriteLine(Encode("cipher", "cccciiiiippphheeeeerrrrrabdfgjklmnoqstuvwxyz"));
Console.WriteLine(Encode("This is an example.", "cccciiiiippphheeeeerrrrrabdfgjklmnoqstuvwxyz"));
Console.WriteLine(Encode("This.tHis.thIs.thiS...", "cccciiiiippphheeeeerrrrrabdfgjklmnoqstuvwxyz"));

////  DECODE
Console.WriteLine("\nDECODE -------------------------");
Console.WriteLine(Decode("ihrbfj", "cipherabdfgjklmnoqstuvwxyz"));
Console.WriteLine(Decode("Urew pu bq rzfsbtj.", "cipherabdfgjklmnoqstuvwxyz"));
Console.WriteLine(Decode("Urew.uRew.urEw.ureW...", "cipherabdfgjklmnoqstuvwxyz"));


Console.WriteLine("\nCOMBINED --------------------------");

var encode_1 = Encode("This is an example.", "cipherabdfgjklmnoqstuvwxyz");
var decode_2 = Decode("Urew pu bq rzfsbtj.", "cipherabdfgjklmnoqstuvwxyz");

Console.WriteLine(Decode(encode_1, "cipherabdfgjklmnoqstuvwxyz"));
Console.WriteLine(Encode(decode_2, "cipherabdfgjklmnoqstuvwxyz"));

static string Encode(string text, string key)
{
    int pos = 1;
    string lText = text.ToLower();
    string KEY =  "cipherabdfgjklmnoqstuvwxyz";

    var sb =  new StringBuilder();

    if (!text.Contains(" "))
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLetter(text[i]))
            {
                sb.Append(char.IsUpper(text[i]) ? char.ToUpper(KEY[KEY.IndexOf(lText[i]) + pos++]) :
                    KEY[KEY.IndexOf(lText[i]) + pos++]);
            }
            else
            {
                pos = 1;
                sb.Append(text[i]);
            }
        }
        return sb.ToString();
    }

    for (int i = 0; i < text.Length; i++)
    {
        if (pos > key.Length) pos -= key.Length;
        if (text[i] == ' ')
        {
            pos = 1;
            sb.Append(" ");
        }
        else if (char.IsLetter(text[i]))
        {
            sb.Append(char.IsUpper(text[i]) ? char.ToUpper(KEY[KEY.IndexOf(lText[i]) + pos++]) :
                KEY[KEY.IndexOf(lText[i]) + pos++]);
        }
        else sb.Append(text[i]);
    }
    return sb.ToString();
}

static string Decode(string text, string key)
{
    int pos = 1;
    string lText = text.ToLower();
    string KEY = "cipherabdfgjklmnoqstuvwxyz";
    var sb = new StringBuilder();

    if (!text.Contains(" "))
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLetter(text[i]))
            {
                sb.Append(char.IsUpper(text[i]) ? char.ToUpper(KEY[KEY.IndexOf(lText[i]) - pos++]) :
                    KEY[KEY.IndexOf(lText[i]) - pos++]);
            }
            else
            {
                pos = 1;
                sb.Append(text[i]);
            }
        }
        return sb.ToString();
    }

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == ' ')
        {
            pos = 1;
            sb.Append(" ");
        }
        else if (char.IsLetter(text[i]))
        {
            sb.Append(char.IsUpper(text[i]) ? char.ToUpper(KEY[KEY.IndexOf(lText[i]) - pos++]) :
                KEY[KEY.IndexOf(lText[i]) - pos++]);
        }
        else sb.Append(text[i]);
    }
    return sb.ToString();
}


Console.ReadLine();