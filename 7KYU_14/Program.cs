namespace _7KYU_14;

internal class Program
{
    static void Main(string[] args)
    {
        string asd = "Hello World!!";
        
        Console.WriteLine(asd.Remove(asd.IndexOf("W")));

        Console.ReadLine();
    }

    // SOLUTION
    public static string RemoveUrlAnchor(string url)
    {
        return url.Contains("#") ? url.Remove(url.IndexOf("#")) : url;
    }

    // OTHER ANSWER ----------

    public static string _RemoveUrlAnchor(string url)
    {
        return url.Split('#')[0];
    }

}
