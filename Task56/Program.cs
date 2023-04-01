// 56. Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] newMatrix = CreateMatrixInt(4, 4, 1, 10);
PrintMatrix(newMatrix);

int[,] matrixSumEveryRow = GetMatrixSumToAllRow(newMatrix);

for (int i = 0; i < matrixSumEveryRow.GetLength(0); i++)
{
    Console.WriteLine($"Индекс строки: {matrixSumEveryRow[i, 0]}, сумма: {matrixSumEveryRow[i, 1]}");
}

int indexRowWithSmallesSum = FindRowWithSmallestSum(matrixSumEveryRow);
Console.WriteLine($"\nИндекс строки с наименьшей суммой -> {indexRowWithSmallesSum}");

///////////////////////////////////////////////////////////////////////////////
int FindRowWithSmallestSum(int[,] matrixSum)
{
    int minSum = matrixSum[0, 1];
    int rowIndex = 0;

    for (int i = 1; i < matrixSum.GetLength(0); i++)
    {
        int sum = matrixSum[i, 1];
        if (sum < minSum)
        {
            minSum = sum;
            rowIndex = matrixSum[i, 0];
        }
    }
    return rowIndex;
}

int[,] GetMatrixSumToAllRow(int[,] matrix)
{
    int[,] matrixSum = new int[matrix.GetLength(1), 2];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = matrix[i, 0];
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }

        matrixSum[i, 0] = i;
        matrixSum[i, 1] = sum;
    }
    return matrixSum;
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