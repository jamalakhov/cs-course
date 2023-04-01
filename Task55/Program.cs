// 55. Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

Console.Clear();

int[,] myMatrix = CreateMatrixInt(3, 3, 1, 10);
PrintMatrix(myMatrix);

if (IsSquare(myMatrix))
{
    ChangeColumsAndRows(myMatrix);
    PrintMatrix(myMatrix);
}
else
{
    Console.WriteLine("Количество строк не совпадает с количеством столбцов");
}

///////////////////////////////////////////////////////////////////////////////
void ChangeColumsAndRows(int[,] matrix)
{
    int size = matrix.GetLength(0);
    for (int i = 0; i < size - 1; i++)
    {
        for (int j = i + 1; j < size; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

bool IsSquare(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
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