// 3. Напишите программу, которая будет выдавать 
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

bool condition = true;
string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение" };

Console.Clear();

//Запускаем цикл
while (condition)
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
            int day = Convert.ToInt32(number);

            //Проверяем корректное-ли число было введено
            if (day > daysOfWeek.Length || day <= 0)
            {
                Console.WriteLine($"Введено некорректное число -> ({day})");
            }
            else
            {
                //Если все ОК, то печатаем ответ и выходим из цикла
                Console.WriteLine(daysOfWeek[day - 1]);        
                condition = false;
            }
        }
        else
        {
            Console.WriteLine($"Полученное значение -> ({str}) <- не является числом");
        }
    }
    else
    {
        Console.WriteLine("Вводимое значение не может быть пустым");
    }
}