// 5. Напишите программу, которая на вход
// принимат одно число (N), а на выходе показывает
// все целые числа в промежутке от -N до N.

// Например:
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"

Console.Clear();

//Запускаем цикл
while (true)
{
    Console.Write("<----- Введите целое положительное число: ");

    var input = Console.ReadLine();

    //Проверяем входящее значение на null
    if (input != null)
    {
        var str = input.Trim().Split(' ')[0];
        double number;

        //Проверяем возможность конвертации строки в число
        if (double.TryParse(str, out number))
        {
            //Проверяем на целое число
            if (Convert.ToInt32(number) == Convert.ToDouble(number))
            {
                int myInt = Convert.ToInt32(number);
                //Проверяем на положительное число
                if (myInt > 0)
                {
                    //Печатаем числа
                    for (int i = -myInt; i <= myInt; i++)
                    {
                        Console.Write($"{i} ");
                    }
                    //Завершаем цикл
                    break;
                }
                else
                {
                    Print($"Ошибка: отрицательное число или '0' ({number})");
                }
            }
            else
            {
                Print($"Ошибка: дробное число ({number})");
            }
        }
        else
        {
            Print($"Полученное значение -> ({str}) <- не является числом");
        }
    }
    else
    {
        Print("Вводимое значение не может быть пустым");
    }
}
static void Print(string result)
{
    Console.WriteLine(result);
}