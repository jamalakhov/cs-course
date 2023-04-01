// 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.Clear();

int x = 10;
int y = 9;
int z = 1;
int startNumber = 11;

if (IsValid3DMatrix(x, y, z, startNumber))
{
    int[,,] matrix3D = Create3DMatrix(x, y, z, startNumber);
    Print3DMatrix(matrix3D);
}
else
{
    Console.WriteLine($"Создание 3D матрицы с размером ({x}, {y}, {z}) и стартовым номером ({startNumber}) невозможна");
}
///////////////////////////////////////////////////
bool IsValid3DMatrix(int x, int y, int z, int number)
{
    int count = x * y * z;
    if (number < 10 || number > 99) return false;
    if (count > 90 || count <= 0) return false;
    if (count + number > 100) return false;
    else return true;
}

int[,,] Create3DMatrix(int x, int y, int z, int number)
{
    int[,,] matrix = new int[x, y, z];

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                matrix[i, j, k] = number++;
            }
        }
    }
    return matrix;
}

void Print3DMatrix(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                Console.Write($"{matrix3D[i, j, k]}({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}