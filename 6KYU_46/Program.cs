// Description
//
//     Middle Earth is about to go to war. The forces of good will have many battles with the forces of evil. Different races will certainly be involved. Each race has a certain worth when battling against others. On the side of good we have the following races, with their associated worth:
//
// Hobbits: 1
// Men: 2
// Elves: 3
// Dwarves: 3
// Eagles: 4
// Wizards: 10
//
// On the side of evil we have:
//
// Orcs: 1
// Men: 2
// Wargs: 2
// Goblins: 2
// Uruk Hai: 3
// Trolls: 5
// Wizards: 10
//
// Although weather, location, supplies and valor play a part in any battle, if you add up the worth of the side of good and compare it with the worth of the side of evil, the side with the larger worth will tend to win.
//
//     Thus, given the count of each of the races on the side of good, followed by the count of each of the races on the side of evil, determine which side wins.
//     Input:
//
// The function will be given two parameters. Each parameter will be a string of multiple integers separated by a single space. Each string will contain the count of each race on the side of good and evil.
//
//     The first parameter will contain the count of each race on the side of good in the following order:
//
// Hobbits, Men, Elves, Dwarves, Eagles, Wizards.
//
//     The second parameter will contain the count of each race on the side of evil in the following order:
//
// Orcs, Men, Wargs, Goblins, Uruk Hai, Trolls, Wizards.
//
// All values are non-negative integers. The resulting sum of the worth for each side will not exceed the limit of a 32-bit integer.
//     Output:
//
// Return "Battle Result: Good triumphs over Evil" if good wins, "Battle Result: Evil eradicates all trace of Good" if evil wins, or "Battle Result: No victor on this battle field" if it ends in a tie.

Console.WriteLine(GoodVsEvil("1 1 1 1 1 1", "1 1 1 1 1 1 1"));
Console.WriteLine(GoodVsEvil("0 0 0 0 0 10", "0 1 1 1 1 0 0"));
Console.WriteLine(GoodVsEvil("1 0 0 0 0 0", "1 0 0 0 0 0 0"));

static string GoodVsEvil(string good, string evil)
{
    var goodMembers = new Dictionary<string, int>()
    {
        { "Hobbit", 1 },
        { "Men", 2 },
        { "Elves", 3 },
        { "Dwarves", 3 },
        { "Eagles", 4 },
        { "Wizards", 10 },
    };
    
    var evilMembers = new Dictionary<string, int>()
    {
        { "Orcs", 1 },
        { "Men", 2 },
        { "Wargs", 2 },
        { "Goblins", 2 },
        { "Uruk Hai", 3 },
        { "Trolls", 5 },
        { "Wizards", 10 },
    };

    int gTotal = 0, gPos = 0;
    var gCount = good.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    foreach (var each in goodMembers)
    {
        if (gCount[gPos] != "0")
            gTotal += each.Value * int.Parse(gCount[gPos]);
        
        gPos++;
    }

    int eTotal = 0, ePos = 0;
    var eCount = evil.Split(' ',  StringSplitOptions.RemoveEmptyEntries);
    foreach (var each in evilMembers)
    {
        if (eCount[ePos] != "0")
            eTotal += each.Value * int.Parse(eCount[ePos]);
        
        ePos++;
    }

    return gTotal > eTotal ? "Battle Result: Good triumphs over Evil" :
        gTotal < eTotal ? "Battle Result: Evil eradicates all trace of Good" :
        "Battle Result: No victor on this battle field";
}