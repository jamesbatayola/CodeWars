// If we were to set up a Tic-Tac-Toe game, we would want to know whether the board's current state is solved, wouldn't we? Our goal is to create a function that will check that for us!

// Assume that the board comes in the form of a 3x3 array, where the value is 0 if a spot is empty, 1 if it is an "X", or 2 if it is an "O", like so:

// [[0, 0, 1],
//  [0, 1, 2],
//  [2, 1, 0]]

// We want our function to return:

//    -1 if the board is not yet finished AND no one has won yet (there are empty spots),
//    1 if "X" won,
//    2 if "O" won,
//    0 if it's a cat's game (i.e. a draw).

// You may assume that the board passed in is valid in the context of a game of Tic-Tac-Toe.

Console.WriteLine(IsSolved(new int[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } })); // 1
//Console.WriteLine(IsSolved(new int[,] { { 2, 1, 2 }, { 2, 1, 1 }, { 1, 2, 1 } })); // 0
//Console.WriteLine(IsSolved(new int[,] { { 2, 1, 1 }, { 0, 1, 1 }, { 2, 2, 2 } })); // 2
//Console.WriteLine(IsSolved(new int[,] { { 0, 1, 1 }, { 2, 0, 2 }, { 2, 1, 0 } })); // -1
//Console.WriteLine(IsSolved(new int[,] { { 1, 2, 1 }, { 1, 1, 2 }, { 2, 2, 0 } })); // -1

int IsSolved(int[,] board)
{
    int winner = 0;
    bool containsEmpty = false;

    for (int i = 0; i < board.GetLength(0); i++)
    {
        for (int j = 0; j < board.GetLength(1); j++)
        {
            if (board[i, j] == 0) 
            {
                containsEmpty = true; break;
            } 
        }
        // horizontal 
        if (board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2])
        {
            winner = board[i, 0]; break;
        }
        // verticals
        else if (board[0, i] == board[1, i] && board[0, i] == board[2, i])
        {
            winner = board[0, i]; break;
        }
        // cross
        else if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2] ||
                board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
        {
            winner = board[0, 0]; break;
        }
    }

    return containsEmpty && winner != 0 || !containsEmpty && winner != 0 ? winner : // winner
           containsEmpty && winner == 0 ? -1 : // draw
           0; // unfinished
}

// OTHER ANSWER ------------------
public class _TicTacToe
{
    public int IsSolved(int[,] board)
    {
        int d1 = 1, d2 = 1;
        bool empty = false;
        for (int i = 0; i < 3; i++)
        {
            d1 *= board[i, i];
            d2 *= board[2 - i, i];
            int row = 1, col = 1;
            for (int j = 0; j < 3; j++)
            {
                row *= board[i, j];
                col *= board[j, i];
            }
            if (row == 1 || col == 1) return 1;
            if (row == 8 || col == 8) return 2;
            if (row == 0 || col == 0) empty = true;
        }
        if (d1 == 1 || d2 == 1) return 1;
        if (d1 == 8 || d2 == 8) return 2;
        if (empty) return -1;
        return 0;
    }
}

public class __TicTacToe
{
    public int IsSolved(int[,] a)
    {
        if (a[0, 0] != 0 && a[0, 0] == a[0, 1] && a[0, 1] == a[0, 2]) return a[0, 0];
        if (a[1, 0] != 0 && a[1, 0] == a[1, 1] && a[1, 1] == a[1, 2]) return a[1, 0];
        if (a[2, 0] != 0 && a[2, 0] == a[2, 1] && a[2, 1] == a[2, 2]) return a[2, 0];
        if (a[0, 0] != 0 && a[0, 0] == a[1, 0] && a[1, 0] == a[2, 0]) return a[0, 0];
        if (a[0, 1] != 0 && a[0, 1] == a[1, 1] && a[1, 1] == a[2, 1]) return a[0, 1];
        if (a[0, 2] != 0 && a[0, 2] == a[1, 2] && a[1, 2] == a[2, 2]) return a[0, 2];
        if (a[0, 0] != 0 && a[0, 0] == a[1, 1] && a[1, 1] == a[2, 2]) return a[0, 0];
        if (a[0, 2] != 0 && a[0, 2] == a[1, 1] && a[1, 1] == a[2, 0]) return a[0, 2];
        if ((from int d in a where d == 0 select d).Count() > 0) return -1;
        return 0;
    }
}



Console.ReadLine();