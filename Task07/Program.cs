// 7. Напишите программу, которая на вход
// принимает трехзначное число и на выходе
// показывает последнюю цифру этого числа

// Например:
// 456 -> 6


Console.Clear();

//Запускаем цикл
while (true)
{
    Console.Write("<----- Введите трехзначное число: ");

    var input = Console.ReadLine();

    //Проверяем входящее значение на null
    if (input != null)
    {
        string str = input.Trim().Split(' ')[0];
        double number;

        //Проверяем возможность конвертации строки в число
        if (double.TryParse(str, out number))
        {
            // Проверяем на целое число
            if (Convert.ToInt32(number) == Convert.ToDouble(number))
            {
                int myInt = Math.Abs(Convert.ToInt32(number));

                //Проверка на 3-х значное число
                if (myInt >= 100 && myInt < 1000)
                {
                    //Печатаем и выходим из цикла
                    Print((myInt % 10).ToString());
                    break;
                }
                else
                {
                    Print($"Ошибка: не трехзначное число ({number})");
                }
            }
            else
            {
                Print($"Ошибка: дробное число ({number})");
            }
        }
        else
        {
            Print($"Ошибка: значение ({str}) не является числом");
        }
    }
    else
    {
        Print("Ошибка: пустой ввод");
    }
}
static void Print(string result)
{
    Console.WriteLine(result);
}