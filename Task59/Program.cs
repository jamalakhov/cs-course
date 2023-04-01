// 59. Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива

Console.Clear();

int[,] myMatrix = CreateMatrixInt(5, 5, -1, 4);
PrintMatrix(myMatrix);

(int minI, int minJ) = FindMinElement(myMatrix);

int[,] newMatrix = DropColumnAndRow(minI, minJ, myMatrix);
PrintMatrix(newMatrix);

////////////////////////////////////////////////////////////
int[,] DropColumnAndRow(int minI, int minJ, int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    int[,] newMatrix = new int[rows - 1, columns - 1];

    for (int i = 0, newRow = 0; i < rows; i++)
    {
        if (i == minI) continue;

        for (int j = 0, newColumn = 0; j < columns; j++)
        {
            if (j == minJ) continue;

            newMatrix[newRow, newColumn] = matrix[i, j];
            newColumn++;
        }
        newRow++;
    }
    return newMatrix;
}

(int, int) FindMinElement(int[,] matrix)
{
    int minI = 0;
    int minJ = 0;
    int minValue = matrix[0, 0];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int element = matrix[i, j];

            if (element < minValue)
            {
                minI = i;
                minJ = j;
                minValue = element;
            }
        }
    }
    return (minI, minJ);
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