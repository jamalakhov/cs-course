// 0. Напишите программу, которая на вход
// принимает число и выдает его квадрат
// (число, умноженное само на себя)
// Например:
// 4 -> 16
// 3 -> 9
// 7 -> 49

Console.Clear();
bool condition = true;

//Запускаем цикл
while (condition)
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
            int number = Convert.ToInt32(output);

            //Если все ОК, то печатаем ответ и выходим из цикла
            Console.WriteLine(number * number);
            condition = false;
        }
        else
        {
            Console.WriteLine($"Полученное значение -> ({str}) <- не является числом");
        }
    }
    else
    {
        Console.WriteLine("Ввод не может быть пустым");
    }
}