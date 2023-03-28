// 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Clear();

int x = ReadConsole("Введите значение x: ") - 1;
int y = ReadConsole("Введите значение y: ") - 1;

double[,] matrix = CreateMatrixDouble(5, 3, -10, 10);
PrintArray(matrix);

string result = CheckElementToMatrix(matrix, x, y) ? matrix[x, y].ToString() : $"{x + 1}, {y + 1} -> такого числа в массиве нет";

Console.WriteLine(result);

//////////////////////////////////////////////////////////////////////////////
bool CheckElementToMatrix(double[,] array, int x, int y)
{
    int rowsMaxIndex = array.GetLength(0) - 1;
    int columnsMaxIndex = array.GetLength(1) - 1;

    if (x < 0 || y < 0) return false;
    if (x > rowsMaxIndex || y > columnsMaxIndex) return false;
    return true;
}

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
    Console.WriteLine();
}

int ReadConsole(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}