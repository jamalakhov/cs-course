// 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int[,] matrix = CreateMatrixInt(5, 3, 1, 10);
PrintMatrix(matrix);

double[] arrayAvgSumEveryColumns = AvgSumEveryColumns(matrix);
PrintArray(arrayAvgSumEveryColumns);

/////////////////////////////////////////////////////////////////////

double[] AvgSumEveryColumns(int[,] matrixInt)
{
    int rows = matrixInt.GetLength(0);
    double[] resultArray = new double[matrixInt.GetLength(1)];

    for (int i = 0; i < matrixInt.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrixInt.GetLength(0); j++)
        {
            sum += matrixInt[j, i];
        }

        double roundAvgSum = Math.Round(sum / rows, 1);
        resultArray[i] = roundAvgSum;
    }
    return resultArray;
}

int[,] CreateMatrixInt(int countRows, int countColumns, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[countRows, countColumns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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

void PrintArray(double[] arr)
{
    Console.WriteLine("{0}", string.Join("; ", arr));
    Console.WriteLine();
}