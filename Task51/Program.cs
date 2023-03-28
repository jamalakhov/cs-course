// 51. Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д).
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();

int[,] myMatrix = CreateMatrixInt(4, 7, 1, 10);
PrintMatrix(myMatrix);

(int sum, int[] diagonalElements) = SumElementsMainDiagonal(myMatrix);
PrintArray(diagonalElements);

PrintResult(sum, diagonalElements);

/////////////////////////////////////////////////////////////////////////
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

(int, int[]) SumElementsMainDiagonal(int[,] matrix)
{
    int sum = 0;
    int min = matrix.GetLength(0) < matrix.GetLength(1) ? matrix.GetLength(0) : matrix.GetLength(1);
    int[] elements = new int[min];

    for (int i = 0; i < min; i++)
    {
        sum += matrix[i, i];
        elements[i] = matrix[i, i];
    }

    return (sum, elements);
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

void PrintResult(int sum, int[] elements)
{
    string joinString = $"{string.Join("+", elements)}";
    Console.WriteLine($"Сумма элементов главной диагонали: {joinString} = {sum}");
}

void PrintArray(int[] arr)
{
    Console.WriteLine("{0}", string.Join(" ", arr));
    Console.WriteLine();
}