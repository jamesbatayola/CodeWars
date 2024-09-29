//Description:
//Task

//Given two positive integers m (width) and n (height), fill a two-dimensional list (or array) of size m-by-n in the following way:

//    (1) All the elements in the first and last row and column are 1.

//    (2) All the elements in the second and second-last row and column are 2, excluding the elements from step 1.

//    (3) All the elements in the third and third-last row and column are 3, excluding the elements from the previous steps.

//    And so on ...

//Examples

//Given m = 5, n = 8, your function should return

//[[1, 1, 1, 1, 1],
// [1, 2, 2, 2, 1],
// [1, 2, 3, 2, 1],
// [1, 2, 3, 2, 1],
// [1, 2, 3, 2, 1], 
// [1, 2, 3, 2, 1],
// [1, 2, 2, 2, 1],
// [1, 1, 1, 1, 1]]

//Given m = 10, n = 9, your function should return

//[[1, 1, 1, 1, 1, 1, 1, 1, 1, 1],
// [1, 2, 2, 2, 2, 2, 2, 2, 2, 1],
// [1, 2, 3, 3, 3, 3, 3, 3, 2, 1], 
// [1, 2, 3, 4, 4, 4, 4, 3, 2, 1], 
// [1, 2, 3, 4, 5, 5, 4, 3, 2, 1], 
// [1, 2, 3, 4, 4, 4, 4, 3, 2, 1], 
// [1, 2, 3, 3, 3, 3, 3, 3, 2, 1], 
// [1, 2, 2, 2, 2, 2, 2, 2, 2, 1], 
// [1, 1, 1, 1, 1, 1, 1, 1, 1, 1]]

// ----- UNFINISHED -----

//var test = CreateBox(7, 8);

//foreach(var row in test)
//{
//    Console.WriteLine(row);
//}

//static int[,] CreateBox(int m, int n)
//{
//    int[,] res = new int[m, n];

//    for(int row = 0; row < n; row++)
//    {
//        res[row, 0] = 1; // first 
//        for(int col = 1; col <= m - 1; col++)
//        {
//            res[row, col] = row == 0 || row == n ? 1 :
//                        row == 1 || row == n - 1 || col == 1 || col == m - 1 ? 2 :
//                        row == 2 || row == n - 2 || col == 2 || col == m - 2 ? 3 :
//                        col;
//        }
//        res[row, m] = 1;
//    }

//    return res;
//}

//Console.ReadLine();