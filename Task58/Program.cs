// 58. Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int[,] matrix1 = CreateMatrixInt(4, 4, 1, 10);
PrintMatrix(matrix1);

int[,] matrix2 = CreateMatrixInt(4, 3, 1, 10);
PrintMatrix(matrix2);

if (CanMultiplyMatrices(matrix1, matrix2))
{
    int[,] multiplyMatrix = MultiplyMatrix(matrix1, matrix2);
    PrintMatrix(multiplyMatrix);
}
else
{
    Console.WriteLine("Количество столбцов первой матрицы не совпадают с количеством строк второй матрицы");
}

///////////////////////////////////////////////////////////////////////
bool CanMultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    return matrix1.GetLength(1) == matrix2.GetLength(0);
}

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                newMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return newMatrix;
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