//Story

//It's a pretty relaxing life here at the nut farm.

//Most of the time we just sit around looking at our nuts.

//But once a year comes harvesting time...

//Harvesting nuts is very easy. We just shake the trees and the nuts fall out!

//As they fall down the nuts might hit branches:

//    Sometimes they bounce left.
//    Sometimes they bounce right.
//    Sometimes they get stuck in the tree and don't fall out at all.

//Legend

//    o = a nut
//    \ = branch. A nut hitting this branch bounces right
//    / = branch. A nut hitting this branch bounces left
//    _ = branch. A nut hitting this branch gets stuck in the tree
//    . = leaves, which have no effect on falling nuts
//    | = tree trunk, which has no effect on falling nuts
//     = empty space, which has no effect on falling nuts

//Kata Task

//Shake the tree and count where the nuts land.

//Output - An array (same width as the tree) which indicates how many nuts fell at each position ^

//^ See the example tests
//Notes

//    The nuts are always found at the top of the tree
//    Nuts do not affect the falling patterns of other nuts
//    There are always enough spaces for nuts to fall between branches
//    There are no branches at the extreme left/right edges of the tree matrix so it is not possible for a nut to fall "out of bounds"

//Example

//.o.oooooo.o.o.oooooo.
//..\.\.../..\.../..\..
//..../..\..../....../.
//.....\...././.\..\.\.
//...../../././...\....
//.../.../..\./.\..\...
//./.......\../.\../...
//....\..../....././...
//.../.\._.\../._../.\.
//.\...././....\../.\..
//./......././.../../..

//101005000020000000040

using System.ComponentModel;

var test1 = ShakeTree(new string[]
        {
          ".oooooo.",
          "........",
          "........",
          "        ",
          "        ",
          "        "
        });

var test2 = ShakeTree(new string[]
        {
          " o o o  ",
          " /    / ",
          "   /    ",
          "  /  /  ",
          "   ||   ",
          "   ||   ",
          "   ||   "
        });

var test3 = ShakeTree(new string[]
        {
          " o o o  ",
          " \\    \\ ",
          "   \\    ",
          "  \\  \\  ",
          "   ||   ",
          "   ||   ",
          "   ||   ",
        });


foreach (var i in test3)
    Console.WriteLine(i);

static int[] ShakeTree(string[] tree)
{
    var slot = new int[tree[0].Length];

    for (int i = 0; i < slot.Length; i++)
    {
        if (tree[0][i] == ' ' || tree[0][i] == '.' ) continue;

        int initPos = i;
        bool stuck = false;

        for (int j = 1; j < tree.Length; j++)
        {
            if (tree[j][initPos] == ' ' || (tree[j][initPos] == '.')) continue;

            if (tree[j][initPos] == '_')
            {
                stuck = true;
                break;
            }

            if (tree[j][initPos] == '/') initPos--;
            else if (tree[j][initPos] == '\\') initPos++;
        }

        if (!stuck) slot[initPos] += 1;
    }

    return slot;
}

Console.ReadLine();