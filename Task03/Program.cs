// 3. Напишите программу, которая будет выдавать 
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение" };

Console.Clear();

//Запускаем цикл
while (true)
{
    Console.Write("<----- Введите номер дня недели: ");

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
                int day = Convert.ToInt32(number);

                //Проверяем корректное-ли число было введено
                if (day > daysOfWeek.Length || day <= 0)
                {
                    Print($"Ошибка: некорректное число -> ({day})");
                }
                else
                {
                    //Если все ОК, то печатаем ответ и выходим из цикла
                    Print(daysOfWeek[day - 1].ToString());
                    break;
                }
            }
            else
            {
                Print("Ошибка: дробное число");
            }
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

    static void Print(string result)
    {
        Console.WriteLine(result);
    }
}