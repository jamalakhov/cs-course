// 45. Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] myArray = CreateArrayRndInt(7, 1, 10);
int[] newArr = CopyArray(myArray);

Console.WriteLine("\nИсходный массив");
PrintArray(myArray);

Console.WriteLine("Новый массив");
PrintArray(newArr);

bool res = Equal(myArray, newArr);
Console.WriteLine(res ? "Равны" : "Не равны");

bool Equal(int[] arr1, int[] arr2)
{
    if (arr1.Length != arr2.Length) return false;

    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] != arr2[i]) return false;
    }
    return true;
}

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
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
    Console.WriteLine("{0}", string.Join(" ", arr));
    Console.WriteLine();
}