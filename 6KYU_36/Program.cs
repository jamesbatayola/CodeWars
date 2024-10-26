//Given an array of large numbers, your task is to:

//    Group the numbers that have the same digits with the same frequencies.
//    Select the smallest number from each group.
//    Add the selected numbers together to compute the total sum.
//    Return the sum of the digits of the total sum.

//Note: A number should only be included in the sum if its group contains at least one other number in the same group
//Example:

//Input: [ 1234, 3142, 66654, 65466, 2143 ]
//Group 1: [1234, 3142, 2143]
//Smallest number in the group: 1234
//Group 2: [66654, 65466]
//Smallest number in the group: 65466
//sumaTotal = 1234 + 65466 = 66700

//Sum of the digits of 66700: 6 + 6 + 7 + 0 + 0 = 19
//Output: 19

//Note:

//    The numbers in the array can have up to 100 digits.

//Input:

//An array of large number. The array will contain between 1 and 1000 elements.
//Output:

//An integer representing the sum of the digits of the total sum.
//Additional Examples:

//Input: [ 12345, 54321, 98765, 56789, 12354, 54312 ]
//- Group 1: [12345, 54321, 12354, 54312]
//  - Smallest number in the group: 12345
//- Group 2: [98765, 56789]
//  - Smallest number in the group: 56789
//sumaTotal = 12345 + 56789 = 69134
//- Sum of the digits of 69134: 6 + 9 + 1 + 3 + 4 = 23
//Output: 23

//Input: [ 111, 11, 1, 222, 22, 2 ]
//- No groups with more than one element, so the total sum is 0.
//- Sum of the digits of 0: 0
//Output: 0

//Good luck!


//Given an array of large numbers, your task is to:

//    Group the numbers that have the same digits with the same frequencies.
//    Select the smallest number from each group.
//    Add the selected numbers together to compute the total sum.
//    Return the sum of the digits of the total sum.

//Note: A number should only be included in the sum if its group contains at least one other number in the same group
//Example:

//Input: [ 1234, 3142, 66654, 65466, 2143 ]
//Group 1: [1234, 3142, 2143]
//Smallest number in the group: 1234
//Group 2: [66654, 65466]
//Smallest number in the group: 65466
//sumaTotal = 1234 + 65466 = 66700

//Sum of the digits of 66700: 6 + 6 + 7 + 0 + 0 = 19
//Output: 19

//Note:

//    The numbers in the array can have up to 100 digits.

//Input:

//An array of large number. The array will contain between 1 and 1000 elements.
//Output:

//An integer representing the sum of the digits of the total sum.
//Additional Examples:

//Input: [ 12345, 54321, 98765, 56789, 12354, 54312 ]
//- Group 1: [12345, 54321, 12354, 54312]
//  - Smallest number in the group: 12345
//- Group 2: [98765, 56789]
//  - Smallest number in the group: 56789
//sumaTotal = 12345 + 56789 = 69134
//- Sum of the digits of 69134: 6 + 9 + 1 + 3 + 4 = 23
//Output: 23

//Input: [ 111, 11, 1, 222, 22, 2 ]
//- No groups with more than one element, so the total sum is 0.
//- Sum of the digits of 0: 0
//Output: 0

//Good luck!


using System.Numerics;

var nums = new string[] { "12345", "54321", "98765", "56789", "12354", "54312 " };

var asd = nums.GroupBy(e => $"{nums.Select(x => x)}".Contains(e));

Console.WriteLine(asd);

//Console.WriteLine(SumOfDigitGroups(new BigInteger[] { 12345, 54321, 98765, 56789, 12354, 54312 } ));

static int SumOfDigitGroups(BigInteger[] numbers)
{
    var groups = new Dictionary<int, int>();

    for (int i = 0; i < numbers.Length; i++)
    {
        int temp = 0;
        for (int j = 0; j < numbers.Length; j++)
        {
            if (i == j) continue;

            if (!$"{numbers[i]}".All(e => $"{numbers[j]}".Contains(e))) continue;

            if (numbers[i] < numbers[j] && !groups.ContainsKey((int)numbers[i]))
            {
                groups[(int) numbers[i]] = 1;
                continue;
            }
        }
    }

    char[] total = $"{groups.Sum(e => e.Key)}".ToCharArray();
    return total.Sum(e => e);
}

//static int SumOfDigitGroups(BigInteger[] numbers)
//{
//    var nums = new List<BigInteger>(numbers);

//    for (int i = 0; i < nums.Count; i++)
//    {
//        for ()
//    }

//    return 0;
//}

Console.ReadLine();