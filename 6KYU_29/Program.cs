//You live in the city of Cartesia where all roads are laid out in a perfect grid. You arrived ten minutes too early to an appointment, so you decided to take the opportunity to go for a short walk. The city provides its citizens with a Walk Generating App on their phones -- everytime you press the button it sends you an array of one-letter strings representing directions to walk (eg. ['n', 's', 'w', 'e']). You always walk only a single block for each letter (direction) and you know it takes you one minute to traverse one city block, so create a function that will return true if the walk the app gives you will take you exactly ten minutes (you don't want to be early or late!) and will, of course, return you to your starting point. Return false otherwise.

//    Note: you will always receive a valid array containing a random assortment of direction letters ('n', 's', 'e', or 'w' only). It will never give you an empty array (that's not a walk, that's standing still!).


Console.WriteLine(IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }));
Console.WriteLine(IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }));
Console.WriteLine(IsValidWalk(new string[] { "w" }));
Console.WriteLine(IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }));

static bool IsValidWalk(string[] walk)
{
    int ver = 0, hor = 0, min = 0;
    foreach (string dir in walk)
    {
        min++;
        switch (dir)
        {
            case "n": ver += 1; break;
            case "s": ver -= 1; break;
            case "e": hor += 1; break;
            case "w": hor -= 1; break;
        }
    }
    return ver == 0 && hor == 0 && min == 10 ? true : false;
}

//static bool _IsValidWalk(string[] walk)
//{
//    var pos = new Dictionary<char, int> { { 'v', 0 }, { 'h', 0 }, { 'm', 0 } };
//    walk.Select(e =>
//         e switch
//         {
//             "n" => pos['v'] += 1,
//             "s" => pos['v'] -= 1,
//             "e" => pos['h'] += 1,
//             "w" => pos['h'] -= 1
//         }
//    );
//    return pos['v'] == 0 && pos['h'] == 0 && pos['m'] == 0 ? true : false;
//}

Console.ReadLine();