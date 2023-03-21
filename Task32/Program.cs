// 32. Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Clear();

int[] arrayElements = CreateArrayRndInt(12, -6, 7);

Console.WriteLine("Before:");
PrintArray(arrayElements);

ConvertElementsToArray(arrayElements);
Console.WriteLine();

Console.WriteLine("After:");
PrintArray(arrayElements);

void ConvertElementsToArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }

    return array;
}

void PrintArray(int[] arr)
{
    Console.WriteLine("[{0}]", string.Join(", ", arr));
}