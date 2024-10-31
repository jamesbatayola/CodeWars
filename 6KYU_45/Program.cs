// Your task, is to create N×N multiplication table, of size provided in parameter.
//
//     For example, when given size is 3:
//
// 1 2 3
// 2 4 6
// 3 6 9
//
// For the given example, the return value should be:
//
// [[1,2,3],[2,4,6],[3,6,9]]

var test1 = MultiplicationTable(3);

foreach(var i in test1)
    Console.WriteLine(i);

static int[,] MultiplicationTable(int size)
{
    int[,] table = new int[size, size];
    
    for (int row = 0; row < size; row++)
    {
        int temp = row + 1;
        for (int column = 0; column < size; column++)
        {
            table[row,column] = temp;
            temp += row + 1;
        }
    }
    
    return table;
}

