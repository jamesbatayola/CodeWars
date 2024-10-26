namespace _6KYU_10;

//  Build Tower
//  Build a pyramid-shaped tower, as an array/list of strings, given a positive integer number of floors.A tower block is represented with "*" character.

//  For example, a tower with 3 floors looks like this:

//  [
//   "  *  ",
//   " *** ",
//   "*****"
//  ]
//  And a tower with 6 floors looks like this:

//  [
//    "     *     ",
//    "    ***    ",
//    "   *****   ",
//    "  *******  ",
//    " ********* ",
//    "***********"
//  ]

internal class Program
{
    static void Main(string[] args)
    {
        var asd = TowerBuilder(8);

        foreach (var i in asd)
            Console.WriteLine(i);

        Console.ReadLine();
    }

    // SOLUTION
    public static string[] TowerBuilder(int nFloors)
    {
        var building = new List<string>();

        int[] odds = Enumerable
                        .Range(1, nFloors)
                        .Select((o, i) => new { o, i })
                        .Select(x => x.o + (x.o - 1))
                        .ToArray();

        for (int i = 0; i < nFloors; i++)
        {
            int left = odds[^1] - odds[i] == 0 ? 0 : (odds[^1] - odds[i]) / 2;
            int right = left == 0 ? 0 : odds[^1] - left;

            string floors = "";
            for (int j = 0; j < odds[^1]; j++)
            {
                if (j < left || j >= right && left > 0 && right > 0)
                {
                    floors += " ";
                }
                else
                {
                    floors += "*";
                }
            }
            building.Add(floors);
        }

        return building.ToArray();
    }

    // OTHER ANSWER ------------

    public static string[] _TowerBuilder(int nFloors)
    {

        List<string> tower = new List<string>();

        int spaces = nFloors - 1, stars = 1;

        for (int i = 0; i < nFloors; i++)
        {
            string floor = "";

            for (int j = 0; j < spaces; j++)
                floor += " ";

            for (int k = 0; k < stars; k++)
                floor += "*";

            for (int l = 0; l < spaces; l++)
                floor += " ";

            tower.Add(floor);
            stars += 2;
            spaces -= 1;
        }

        return tower.ToArray();
    }

}
