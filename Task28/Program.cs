// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();

Console.Write("Введите целое число: ");

int number = Convert.ToInt32(Console.ReadLine());

if(number <= 0)
{
    Console.WriteLine($"Ошибка: введено неверное значение {number}");
    return;
}

int factorial = Factorial(number);

Console.WriteLine($"Произведение чисел до {number}: {factorial}");

int Factorial(int num)
{
    int result = 1;

    for (int i = 2; i <= num; i++)
    {
        checked
        {
            result *= i;            
        }        
    }
    return result;
}