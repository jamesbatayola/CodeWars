namespace _6KYU_13;

// Description:
// There is a queue for the self-checkout tills at the supermarket.Your task is write a function to calculate the total time required for all the customers to check out!

// input
// customers: an array of positive integers representing the queue.Each integer represents a customer, and its value is the amount of time they require to check out.
// n: a positive integer, the number of checkout tills.
// output
// The function should return an integer, the total time required.

// Important
// Please look at the examples and clarifications below, to ensure you understand the task correctly :)

// Examples
//// queueTime([5, 3, 4], 1)
//// should return 12
//// because when there is 1 till, the total time is just the sum of the times

// queueTime([10, 2, 3, 3], 2)
//// should return 10
//// because here n=2 and the 2nd, 3rd, and 4th people in the 
//// queue finish before the 1st person has finished.

// queueTime([2, 3, 10], 2)
//// should return 12
// Clarifications
// There is only ONE queue serving many tills, and
// The order of the queue NEVER changes, and
// The front person in the queue(i.e.the first element in the array/list) proceeds to a till as soon as it becomes free.

internal class Program
{
    static void Main(string[] args)
    {
        //var nums = new List<int> { 5, 2, 4, 3, 1};

        //nums.Sort();
        //Console.WriteLine(nums[^1] - nums[^2]);

        Console.WriteLine(_QueueTime([5, 3, 4], 1));
        Console.WriteLine(_QueueTime([10, 2, 3, 3], 2));
        Console.WriteLine(_QueueTime([2, 3, 10], 2));

        Console.ReadLine();
    }

    // FORFEIT :(
    public static long QueueTime(int[] customers, int n)
    {
        if (n == 1) return customers.Sum();
        else if (n > customers.Length) return customers.Max();
        else if (n <= 1) return 0;

        int tSpan = 0;

        var tills = new List<int>();

        for(int i = 0; i < customers.Length; i++)
        {
            tills.Add(customers[i]);
            if(tills.Count == n)
            {
                if (i == customers.Length - 1)
                {
                    int a = tills.Count > 1 ? tills.Max() : tills[0];
                    tSpan += a;
                    break;
                }

                tills.Sort();
                tSpan += tills[^2] ;
                int temp = tills[^1] - tills[^2];
                tills.Clear();
                tills.Add(temp);
            }
        }

        return tSpan;
       
    }

    public static long _QueueTime(int[] customers, int n)
    {
        var checkout = new int[n];

        foreach (var customer in customers)
        {
            checkout[Array.IndexOf(checkout, checkout.Min())] += customer;
        }

        return checkout.Max();
    }


}
