// Return an array containing the numbers from 1 to N, where N is the parametered value.
//
//     Replace certain values however if any of the following conditions are met:
//
// If the value is a multiple of 3: use the value "Fizz" instead
//     If the value is a multiple of 5: use the value "Buzz" instead
//     If the value is a multiple of 3 & 5: use the value "FizzBuzz" instead
//
//     N will never be less than 1.
//
//     Method calling example:
//
// string[] result = FizzBuzz.GetFizzBuzzArray(3); // => [ "1", "2", "Fizz" ]
// ;

var test1 = GetFizzBuzzArray(15);
foreach (var i in test1)
{
    Console.WriteLine(i);
}

static string[] GetFizzBuzzArray(int n)
{
    var res = new string[n];
    for (int i = 1; i <= n; i++)
    {
        res[i-1] = i % 3 == 0 && i % 5 == 0 ? "FizzBuzz" : i % 3 == 0 ? "Fizz" : i % 5 == 0 ? "Buzz" : $"{i}";
    }
    return res;
}