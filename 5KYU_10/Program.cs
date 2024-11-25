// This problem takes its name by arguably the most important event in the life of the ancient historian Josephus: according to his tale, he and his 40 soldiers were trapped in a cave by the Romans during a siege.
//
//     Refusing to surrender to the enemy, they instead opted for mass suicide, with a twist: they formed a circle and proceeded to kill one man every three, until one last man was left (and that it was supposed to kill himself to end the act).
//
//     Well, Josephus and another man were the last two and, as we now know every detail of the story, you may have correctly guessed that they didn't exactly follow through the original idea.
//
//     You are now to create a function that returns a Josephus permutation, taking as parameters the initial array/list of items to be permuted as if they were in a circle and counted out every k places until none remained.
//
//     Tips and notes: it helps to start counting from 1 up to n, instead of the usual range 0 to n-1; k will always be >=1.
//
//     For example, with an array=[1,2,3,4,5,6,7] and k=3, the function should act this way.
//
//     [1,2,3,4,5,6,7] - initial sequence
//     [1,2,4,5,6,7] => 3 is counted out and goes into the result [3]
//     [1,2,4,5,7] => 6 is counted out and goes into the result [3,6]
//     [1,4,5,7] => 2 is counted out and goes into the result [3,6,2]
//     [1,4,5] => 7 is counted out and goes into the result [3,6,2,7]
//     [1,4] => 5 is counted out and goes into the result [3,6,2,7,5]
//     [4] => 1 is counted out and goes into the result [3,6,2,7,5,1]
//     [] => 4 is counted out and goes into the result [3,6,2,7,5,1,4]
// So our final result is:
//
// [3,6,2,7,5,1,4]

var test1 = JosephusPermutation([1, 2, 3, 4, 5, 6, 7], 3);
var test2 = JosephusPermutation(["C", "o", "d", "e", "W", "a", "r", "s"], 4);

foreach (var i in test1)
    Console.WriteLine(i);

static List<object> JosephusPermutation(List<object> items, int k)
{
    var res = new List<object>();
    int iterator = k;
    while (items.Count > 0)
    {
        while (iterator > items.Count)
            iterator -= items.Count;

        res.Add(items[iterator - 1]);
        items.RemoveAt(iterator - 1);

        iterator = (iterator + k - 1 > items.Count) ? 
            (iterator + k - 1) - items.Count : iterator += k - 1;
    }

    return res;
}

// create list = var_
// create iteration limit = limit_ (equals to param list size)
// loop the inputted list until it equals to the var_ size
//  - interval removal every k
//  - checks if the selected interval is existing in the var_
//      - false = add | true = skip
// 