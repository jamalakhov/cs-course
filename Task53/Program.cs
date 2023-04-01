// 53. Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

Console.Clear();

int[,] myMatrix = CreateMatrixInt(6, 4, 1, 10);
PrintMatrix(myMatrix);

System.Console.WriteLine();

ChangeFirstAndLastRows(myMatrix);
PrintMatrix(myMatrix);

void ChangeFirstAndLastRows(int[,] matrix)
{
    int firstRow = 0;
    int lastRow = matrix.GetLength(0) - 1;

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[firstRow, i];
        matrix[firstRow, i] = matrix[lastRow, i];
        matrix[lastRow, i] = temp;
    }
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