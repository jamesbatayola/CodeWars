namespace q1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DaysInMonth("janu"));
    }
    public static string DaysInMonth(string month)
    {
        var days = new Dictionary<string, int>()
        {
            { "January", 31 }, { "Febuary", 28 }, { "Marh", 31 }, { "April", 30 },
            { "May", 31 }, { "June", 30 }, { "July", 31 }, { "August", 31 },
            { "September", 30 }, { "October", 31 }, { "November", 30 }, { "December", 31 }
        };

        var res = days.FirstOrDefault(e => e.Key.Contains(month, StringComparison.OrdinalIgnoreCase));

        return $"{res.Key} has {res.Value} days in it";
    }
}