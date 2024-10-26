//This is related to my other Kata about cats and dogs.
//Kata Task

//I have a cat and a dog which I got as kitten / puppy.

//I forget when that was, but I do know their current ages as catYears and dogYears.

//Find how long I have owned each of my pets and return as a list [ownedCat, ownedDog]

//NOTES:

//Results are truncated whole numbers of "human" years

//Cat Years

//    15 cat years for first year
//    +9 cat years for second year
//    +4 cat years for each year after that

//Dog Years

//    15 dog years for first year
//    +9 dog years for second year
//    +5 dog years for each year after that


Console.WriteLine(OwnedCatAndDog(15, 15));
Console.WriteLine(OwnedCatAndDog(12, 11));
Console.WriteLine(OwnedCatAndDog(24, 24));
Console.WriteLine(OwnedCatAndDog(56, 64));

Console.WriteLine("\nRandom Test");

Console.WriteLine(OwnedCatAndDog(12, 28));

static (int, int) OwnedCatAndDog(int catYears, int dogYears)
{
    int catAge = catYears < 15 ? 0
               : catYears < 24 ? 1
               : catYears < 28 ? 2
               : 3 + (catYears - 28) / 4;
               
    int dogAge = dogYears < 15 ? 0
               : dogYears < 24 ? 1
               : dogYears < 29 ? 2
               : 3 + (dogYears - 29) / 5;
        
    return (catAge, dogAge);
}

Console.ReadLine();