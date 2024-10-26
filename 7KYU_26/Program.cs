// Every now and then people in the office moves teams or departments. Depending what people are doing with their time they can become more or less boring. Time to assess the current team.

// You will be provided with an object(staff) containing the staff names as keys, and the department they work in as values.

// Each department has a different boredom assessment score, as follows:

// accounts = 1
// finance = 2
// canteen = 10
// regulation = 3
// trading = 6
// change = 6
// IS = 8
// retail = 5
// cleaning = 4
// pissing about = 25

// Depending on the cumulative score of the team, return the appropriate sentiment:

// <= 80: 'kill me now'
// < 100 & > 80: 'i can handle this'
// 100 or over: 'party time!!'


var test1 = new Dictionary<string, string>() { { "Tim", "accounts" }, { "Jim", "trading" }, { "Sandy", "regulation" }, { "Andy", "accounts" }, { "Katie", "finance" }, { "Laura", "IS" } };
var test2 = new Dictionary<string, string>() { { "Jim", "pissing about" }, { "Tim", "regulation" }, { "Andy", "IS" }, { "Laura", "pissing about" }, { "Alex", "canteen" }, { "John", "canteen" } };
var test3 = new Dictionary<string, string>() { { "Andy", "pissing about" }, { "Tim", "accounts" }, { "Smith", "pissing about" }, { "Randy", "pissing about" }, { "Sandy", "IS" }, { "Laura", "pissing about" } };

Console.WriteLine(Boredom(test1));
Console.WriteLine(Boredom(test2));
Console.WriteLine(Boredom(test3));

static string Boredom(Dictionary<string, string> staff)
{
    int total = 0;

    foreach (var i in staff)
    {
        total += i.Value switch
        {
            "account" => 1,
            "finance" => 2,
            "canteen" => 10,
            "regulation" => 3,
            "trading" => 6,
            "change" => 6,
            "IS" => 8,
            "retail" => 5,
            "cleaning" => 4,
            "pissing about" => 25,
            _ => 0
        };
    }

    return total >= 100 ? "party time!!" : total < 100 && total > 80 ? "i can handle this" : "kill me now";
}

Console.ReadLine();