namespace _7KYU_03;

// In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.
internal class Program
{
    static void Main(string[] args)
    {
        List<object> asd = new List<object>() { 1, 2, "a", "b", "aasf", "1", "123", 123 };

        GetIntegersFromList(asd);
    }

    // SOLUTION
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        return listOfItems.OfType<int>();
    }

}

// COMPLETED :)