// 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();

Console.Write("Введите целое число: ");

int number = Convert.ToInt32(Console.ReadLine());
int sum = SumNumbers(number);

Console.WriteLine(sum);

int SumNumbers(int num)
{
    int sum = 0;

    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }

    return sum;
}