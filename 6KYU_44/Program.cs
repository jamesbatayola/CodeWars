﻿// Create a parser to interpret and execute the Deadfish language.
//
//     Deadfish operates on a single value in memory, which is initially set to 0.
//
//     It uses four single-character commands:
//
// i: Increment the value
// d: Decrement the value
// s: Square the value
// o: Output the value to a result array
//
//     All other instructions are no-ops and have no effect.
//     Examples
//
//     Program "iiisdoso" should return numbers [8, 64].
//     Program "iiisdosodddddiso" should return numbers [8, 64, 3600].

var test1 = Parse("iiisdoso");
var test2 = Parse("iiisdosodddddiso");
foreach(var i in test2)
    Console.WriteLine(i);

static int[] Parse(string data)
{
    int val = 0;

    var res = new List<int>();

    foreach (char op in data)
    {
        switch(op)
        {
            case 'i' : val++; break;
            case 'd' : val--; break;
            case 's' : val *= val; break;
            case 'o' : res.Add(val); break;
        }
    }

    return res.ToArray();
}

Console.ReadLine();