//Task

//Implement a function which takes a number N and returns the N'th row of the sequence below. If the argument is greater than the number of rows in the sequence, then start from the beginning again, e.g. row 27 is the same as row 1.
//Sequence

//1:  ABCDEFGHIJKLMNOPQRSTUVWXYZ
//2:  BBCDEFGHIJKLMNOPQRSTUVWXYZ
//3:  CCCDEFGHIJKLMNOPQRSTUVWXYZ
//4:  DDDDEFGHIJKLMNOPQRSTUVWXYZ
//5:  EEEEEFGHIJKLMNOPQRSTUVWXYZ
//6:  FFFFFFGHIJKLMNOPQRSTUVWXYZ
//7:  GGGGGGGHIJKLMNOPQRSTUVWXYZ
//8:  HHHHHHHHIJKLMNOPQRSTUVWXYZ
//9:  IIIIIIIIIJKLMNOPQRSTUVWXYZ
//10: JJJJJJJJJJKLMNOPQRSTUVWXYZ
//11: KKKKKKKKKKKLMNOPQRSTUVWXYZ
//12: LLLLLLLLLLLLMNOPQRSTUVWXYZ
//13: MMMMMMMMMMMMMNOPQRSTUVWXYZ
//14: NNNNNNNNNNNNNNOPQRSTUVWXYZ
//15: OOOOOOOOOOOOOOOPQRSTUVWXYZ
//16: PPPPPPPPPPPPPPPPQRSTUVWXYZ
//17: QQQQQQQQQQQQQQQQQRSTUVWXYZ
//18: RRRRRRRRRRRRRRRRRRSTUVWXYZ
//19: SSSSSSSSSSSSSSSSSSSTUVWXYZ
//20: TTTTTTTTTTTTTTTTTTTTUVWXYZ
//21: UUUUUUUUUUUUUUUUUUUUUVWXYZ
//22: VVVVVVVVVVVVVVVVVVVVVVWXYZ
//23: WWWWWWWWWWWWWWWWWWWWWWWXYZ
//24: XXXXXXXXXXXXXXXXXXXXXXXXYZ
//25: YYYYYYYYYYYYYYYYYYYYYYYYYZ
//26: ZZZZZZZZZZZZZZZZZZZZZZZZZZ

using System.Text;

//Console.WriteLine(Convert.ToChar(97));
//Console.WriteLine(Convert.ToChar(122));

//Console.WriteLine(GetRow(1));
//Console.WriteLine(GetRow(2));
//Console.WriteLine(GetRow(10));
//Console.WriteLine(GetRow(25));
//Console.WriteLine(GetRow(26));
//Console.WriteLine(GetRow(28));

Console.WriteLine(GetRow(1000));

static string GetRow(int numOfRow)
{
    while (numOfRow > 26) numOfRow -= 26;
    var sb = new StringBuilder();
    for (int i = 97; i <=122 ; i++)
    {
        sb.Append(i <= numOfRow + 96 ? Convert.ToChar(numOfRow + 96) : Convert.ToChar(i));
    }
    return sb.ToString().ToUpper();
}

Console.ReadLine();