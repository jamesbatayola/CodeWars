// A Discovery
// One fine day while Farmer Arepo Tenaciously Labored at Turning the soil, he discovered a field that was scattered with strange stone tablets. Noticing they were carved with letters in a square pattern, he wisely kept them in case some might be special.
//
// Your Task
// Please help Farmer Arepo by inspecting each tablet to see if it forms a valid Sator Square!
//
// The Square
// is a two-dimentional palindrome, made from words of equal length that can be read in these four ways:
//
// 1)    left-to-right    (across)
// 2)    top-to-bottom    (down)
// 3)    bottom-to-top    (up)
// 4)    right-to-left    (reverse)
//
// An Example
// Considering this square:
//
// B A T S
// A B U T
// T U B A
// S T A B
// Here are the four ways a word (in this case "TUBA") can be read:
//
// down
// ↓
// B A T S    B A T S    B A T S    B A T S
// A B U T    A B U T    A B U T    A B U T ← reverse
// across → T U B A    T U B A    T U B A    T U B A
// S T A B    S T A B    S T A B    S T A B
// ↑
// up
// IMPORTANT:
//
// In a true Sator Square, ALL of its words can be read in ALL four of these ways.
// If there is any deviation, it would be false to consider it a Sator Square.
// Some Details
// tablet (square) dimensions range from 2x2 to 33x33 inclusive
// all characters used will be upper-case alphabet letters
// there is no need to validate any input
// Input
// an N x N (square) two-dimentional matrix of uppercase letters
// Output
// boolean true or false whether or not the tablet is a Sator Square

// Console.WriteLine(IsSatorSquare(new char[,]
// {
//     { 'B', 'A', 'T', 'S' },
//     { 'A', 'B', 'U', 'T' },
//     { 'T', 'U', 'B', 'A' },
//     { 'S', 'T', 'A', 'B' },
// }));

// Console.WriteLine(IsSatorSquare(new char[,]
// {
//     { 'T', 'E', 'N' },
//     { 'E', 'Y', 'E' },
//     { 'N', 'E', 'T' },
// }));

// Console.WriteLine(IsSatorSquare(new char[,]
// {
//     { 'N', 'O', 'T' },
//     { 'O', 'V', 'O' },
//     { 'N', 'O', 'T' },
// }));

Console.WriteLine(IsSatorSquare(new char[,]
{
    { 'A', 'A', 'A' },
    { 'A', 'G', 'A' },
    { 'A', 'A', 'A' },
}));

static bool IsSatorSquare(char[,] tablet)
{
    var coll = new List<string>();

    for (int i = 0; i < tablet.GetLength(0); i++)
    {
        string temp1 = "";
        for (int forward = 0; forward < tablet.GetLength(1); forward++)
        {
            temp1 += tablet[i, forward];
        }

        coll.Add(temp1);

        string temp2 = "";
        for (int reverse = tablet.GetLength(1) - 1; 0 <= reverse; reverse--)
        {
            temp2 += tablet[i, reverse];
        }

        coll.Add(temp2);

        string temp3 = "";
        for (int downward = 0; downward < tablet.GetLength(0); downward++)
        {
            temp3 += tablet[downward, i];
        }

        coll.Add(temp3);

        string temp4 = "";
        for (int upward = tablet.GetLength(0) - 1; 0 <= upward; upward--)
        {
            temp4 += tablet[upward, i];
        }

        coll.Add(temp4);
    }

    return coll.GroupBy(e => e).All(e => e.Count() >= 4);
}

// make a dictionary
// loop through 2d array
// populate dictionary with 4 ways
// if one dictionary keys contains 4 values return true