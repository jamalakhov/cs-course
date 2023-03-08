// 6. Напишите программу, которая на вход
// принимает число и выдает, является ли
// число четным (делиться ли оно на два без остатка)

// Например:
// 4 -> да
// -3 -> нет

Console.Clear();

//Запускаем цикл
while (true)
{
    Console.Write("<----- Введите число: ");

    var input = Console.ReadLine();

    //Проверяем входящее значение на null
    if (input != null)
    {
        var str = input.Trim().Split(' ')[0];
        double number;

        //Проверяем возможность конвертации строки в число
        if (double.TryParse(str, out number))
        {
            if (number > 0 && number % 2 == 0)
            {
                Print("да");
            }
            else
            {
                Print("нет");
            }
            break;
        }
        else
        {
            Print($"Ошибка: значение ({str}) не удовлетворяет условиям");
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