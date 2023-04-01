// 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int row = 4;
int column = 4;
int numberStart = 1;

int[,] matrix = CreateMatrixInt(row, column, numberStart);
PrintMatrix(matrix);

/////////////////////////////////////////////////////////////////
int[,] CreateMatrixInt(int rows, int columns, int count)
{
    int rowStart = 0;
    int rowEnd = rows - 1;
    int colStart = 0;
    int colEnd = columns - 1;

    int[,] matrix = new int[rows, columns];

    while (rowStart <= rowEnd && colStart <= colEnd)
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            matrix[rowStart, i] = count++;
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            matrix[i, colEnd] = count++;
        }
        colEnd--;

        if (rowStart <= rowEnd)
        {
            for (int i = colEnd; i >= colStart; i--)
            {
                matrix[rowEnd, i] = count++;
            }
            rowEnd--;
        }

        if (colStart <= colEnd)
        {
            for (int i = rowEnd; i >= rowStart; i--)
            {
                matrix[i, colStart] = count++;
            }
            colStart++;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}