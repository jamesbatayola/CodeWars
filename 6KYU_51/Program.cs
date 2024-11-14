// Introduction
//
//     A student had a couple of bad exams. They thought they would try to convince the professor to allow all the students to drop their lowest exam scores. The professor thought about this and told the student that they would agree to drop the students lowest exam scores if the student was also willing to drop the highest test scores.
//     Task
//
//     Write a program that will take a number of tests to drop int numberToDrop and an array of test scores string[] examResults. Each time you drop, drop both the minimum and maximum value of the remaining exam results.
//
//     If the average score after dropping is higher than the average of the original results (before tests were dropped), then it should return true. If the average score is lower than the original score, then it should return false. If the results are the same (the original score and the dropped score) then it should also return false.
//     Example
//
// an array of test scores will be passed as a parameter ( "97", "62", "75", "85", "98", "98", "59", "81", "89" ). If the student doesn't accept the professors deal, their grade will be 82%. If the student does accept the professors deal, their scores will be ("97","75","85","81","89") for a grade of 85%. In this example the student should accept it.

Console.WriteLine(CalculateScores(2, new string[] { "97", "62", "75", "85", "98", "98", "59", "81", "89" }));
Console.WriteLine(CalculateScores(2, new string[] { "98", "70", "79", "78", "80", "85", "89", "80", "95" }));
Console.WriteLine(CalculateScores(1, ["99", "69", "69", "63", "73", "92", "91", "77", "99"]));

Console.WriteLine(CalculateScores(3, ["74", "82", "90", "72", "91", "95", "73", "97", "79"]));

static bool CalculateScores(int numberToDrop, string[] examResults)
{
    int[] scores = examResults.Select(int.Parse).ToArray();

    var dropped = scores.Order().Skip(numberToDrop).SkipLast(numberToDrop).ToArray();
    
    double initAverage = scores.Average();
    double droppedAverage = dropped.Average();

    return droppedAverage > initAverage;
}

Console.ReadLine();