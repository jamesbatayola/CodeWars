//Greed is a dice game played with five six-sided dice. Your mission, should you choose to accept it, is to score a throw according to these rules. You will always be given an array with five six-sided dice values.

// Three 1's => 1000 points
// Three 6's =>  600 points
// Three 5's =>  500 points
// Three 4's =>  400 points
// Three 3's =>  300 points
// Three 2's =>  200 points
// One   1   =>  100 points
// One   5   =>   50 point

//A single die can only be counted once in each roll. For example, a given "5" can only count as part of a triplet (contributing to the 500 points) or as a single 50 points, but not both in the same roll.

//Example scoring

// Throw       Score
// ---------   ------------------
// 5 1 3 4 1   250:  50(for the 5) +2 * 100(for the 1s)
// 1 1 1 3 1   1100: 1000(for three 1s) +100(for the other 1)
// 2 4 4 5 4   450:  400(for three 4s) +50(for the 5)

Console.WriteLine(Score(new int[] { 2, 2, 2, 2, 3 }));
Console.WriteLine(Score(new int[] { 4, 4, 4, 3, 3 }));
Console.WriteLine(Score(new int[] { 2, 4, 4, 5, 4 }));

static int Score(int[] dice)
{
    int res = 0;
    var rolls = new Dictionary<int, int>() { };

    foreach (int i in dice)
    {
        if (!rolls.ContainsKey(i)) rolls[i] = 1;
        else rolls[i] += 1;
    }

    foreach (var each in rolls)
    {
        if (each.Value >= 3)
        {
            res += each.Key == 1 ? 1000 : each.Key * 100;

            if (each.Key == 1 || each.Key == 5)
                res += each.Key == 1 ? (each.Value - 3) * 100 : (each.Value - 3) * 50;
        }

        else if (each.Value < 3 && each.Key == 1 || each.Key == 5)
            res += each.Key == 1 ? each.Value * 100 : each.Value * 50;
    }

    return res;
}

Console.ReadLine();