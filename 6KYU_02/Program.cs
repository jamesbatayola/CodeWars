namespace _6KYU_02;

/*
 * You probably know the "like" system from Facebook and other pages.
 * People can "like" blog posts, pictures or other items.
 * We want to create the text that should be displayed next to such an item.
 */

/*
 * Implement the function which takes an array containing the names of people that like an item.
 * It must return the display text as shown in the examples:
 */

// []                                -->  "no one likes this"
// ["Peter"]                         -->  "Peter likes this"
// ["Jacob", "Alex"]                 -->  "Jacob and Alex like this"
// ["Max", "John", "Mark"]           -->  "Max, John and Mark like this"
// ["Alex", "Jacob", "Mark", "Max"]  -->  "Alex, Jacob and 2 others like this"

internal class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Alex", "Jacob", "Mark", "Max" };

        var s = names[1..3];

        //Console.WriteLine(Likes(names));

        Console.ReadLine();
    }

    public static string Likes(string[] name)
    {
        return name.Count() switch
        {
            0 => "no one likes this",
            1 => $"{name[0]} likes this",
            2 => $"{name[0]} and {name[1]} like this",
            3 => $"{name[0]}, {name[1]} and {name[2]} like this",
            _ => $"{name[0]}, {name[1]} and {name.Skip(2).Count()} others like this"
        };

    }

}

// COMPLETED :)
