// Given an array with exactly 5 strings "a", "b" or "c" (chars in Java, characters in Fortran, Chars in Haskell), check if the array contains three and two of the same values.
// Examples

// ["a", "a", "a", "b", "b"] ==> true  // 3x "a" and 2x "b"
// ["a", "b", "c", "b", "c"] ==> false // 1x "a", 2x "b" and 2x "c"
// ["a", "a", "a", "a", "a"] ==> false // 5x "a"

// Given an array with exactly 5 strings "a", "b" or "c" (chars in Java, characters in Fortran, Chars in Haskell), check if the array contains three and two of the same values.
// Examples

// ["a", "a", "a", "b", "b"] ==> true  // 3x "a" and 2x "b"
// ["a", "b", "c", "b", "c"] ==> false // 1x "a", 2x "b" and 2x "c"
// ["a", "a", "a", "a", "a"] ==> false // 5x "a"

Console.WriteLine(CheckThreeAndTwo(new string[] { "a", "a", "a", "b", "b" }));
Console.WriteLine(CheckThreeAndTwo(new string[] { "a", "b", "c", "b", "c" }));
Console.WriteLine(CheckThreeAndTwo(new string[] { "a", "a", "a", "a", "a" }));

static bool CheckThreeAndTwo(string[] array)
{
    var group = array.GroupBy(e => e);
    return group.All(e => e.Count() == 3 || e.Count() == 2);
}

Console.ReadLine();