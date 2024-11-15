//Write a generic function chainer

//Write a generic function chainer that takes a starting value, and an array of functions to execute on it (array of symbols for Ruby).

//The input for each function is the output of the previous function (except the first function, which takes the starting value as its input). Return the final value after execution is complete.

static double add(double x)
{
    return x + 1;
}
static double mul(double x)
{
    return x * 30;
}

var asd = new[] { add, mul };

Chain(2, asd);

static double Chain(double input, Func<double, double>[] fs)
{
    double temp = input;
    foreach (var func in fs)
    {
        temp = func(temp);
    }
    return temp;
}