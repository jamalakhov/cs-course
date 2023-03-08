// 8. Напишите программу, которая на вход
// принимает число (N), а на выходе
// показывает все четные числа от 1 до N

// Например:
// 5 -> 2, 4

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
                if (myInt > 1)
                {
                    //Печатаем числа                    
                    for (int i = 2; i <= myInt; i += 2)
                    {
                        Console.Write($"{i} ");
                    }
                    //Завершаем цикл
                    break;
                }
                else
                {
                    Print($"Ошибка: число -> ({myInt}) меньше или равно 1");
                }
            }
            else
            {
                Print($"Ошибка: дробное число ({number})");
            }
        }
        else
        {
            Print($"Ошибка: не является числом -> ({str})");
        }
    }
    else
    {
        Print("Ошибка: значение не может быть пустым");
    }
}
static void Print(string result)
{
    Console.WriteLine(result);
}