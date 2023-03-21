// 33. Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();

int[] randomArray = CreateArrayRndInt(10, -10, 10);

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = IsPresent(randomArray, number);

Console.WriteLine(result ? "ДА" : "НЕТ");

PrintArray(randomArray);

bool IsPresent(int[] arr, int number)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number) return true;
    }

    return false;
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