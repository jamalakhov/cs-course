// 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

double[,] matrix = CreateMatrixDouble(5, 3, -10, 10);
PrintArray(matrix);

//////////////////////////////////////////////////////////////////////////////
double[,] CreateMatrixDouble(int countRows, int countColums, int max, int min)
{
    Random random = new Random();
    double[,] matrix = new double[countRows, countColums];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double digit = random.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(digit, 1, MidpointRounding.AwayFromZero);
        }
    }

    return matrix;
}

void PrintArray(double[,] matrixArr)
{
    for (int i = 0; i < matrixArr.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArr.GetLength(1); j++)
        {
            Console.Write($"{matrixArr[i, j],5} ");
        }
        Console.WriteLine();
    }
}