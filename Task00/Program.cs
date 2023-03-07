// 0. Напишите программу, которая на вход
// принимает число и выдает его квадрат
// (число, умноженное само на себя)
// Например:
// 4 -> 16
// 3 -> 9
// 7 -> 49

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
        double output;

        //Проверяем возможность конвертации строки в число
        if (double.TryParse(str, out output))
        {
            //Проверяем на целое число
            if (Convert.ToInt32(output) == Convert.ToDouble(output))
            {
                int number = Convert.ToInt32(output);

                //Если все ОК, то печатаем ответ и выходим из цикла
                Console.WriteLine(number * number);                
                break;
            }
            else
            {
                Console.WriteLine("Ошибка: дробное число");
            }
        }
        else
        {
            Console.WriteLine($"Ошибка: не является числом -> ({str})");
        }
    }
    else
    {
        Console.WriteLine("Ошибка: пустое значение");
    }
}