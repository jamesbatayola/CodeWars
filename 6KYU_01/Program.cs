namespace _6KYU_01;

internal class Program
{
    static void Main(string[] args)
    {
        IEnumerable<int> asd = new int[] { 11, 11, 14, 11, 11};

        Console.WriteLine(GetUnique(asd));

        Console.ReadLine();
    }

    // SOLUTION
    public static int GetUnique(IEnumerable<int> numbers)
    {

        var collection = new List<int>(numbers);

        var unique = collection
                    .GroupBy(x => x)
                    .OrderBy(x => x.Count())
                    .Select(x => x.Key)
                    .ToArray();

        return unique[0];
    }


}