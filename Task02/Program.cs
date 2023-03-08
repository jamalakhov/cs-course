// 2. Напишите программу, которая на вход
// принимает два числа и выдает большее число

// Например:
// 5; 7 -> max = 7

Console.Clear();

bool condition = true;

//Запускаем цикл
while (condition)
{
    bool myBrake = false;

    Console.Write("<----- Введите два числа через символ ';': ");

    var input = Console.ReadLine();

    //Проверяем входящее значение на null
    if (input != null)
    {
        string[] str = input.Trim().Split(';');

        //Проверяем количество введенных значений
        if (str.Length == 2)
        {
            double[] arrayDouble = new double[2];

            //Проверяем возможность конвертации строки в число
            for (int i = 0; i < str.Length; i++)
            {
                double number;
                if (double.TryParse(str[i].Trim(), out number))
                {
                    arrayDouble[i] = number;
                }
                else
                {
                    Print($"Ошибка: не является числом -> ({str[i]})");
                    myBrake = true;
                    break;
                }
            }

            if (myBrake)
            {
                continue;
            }

            //Сравниваем числа
            if (arrayDouble[0] > arrayDouble[1])
            {
                Print($"max = {arrayDouble[0]}");
            }
            else
            {
                Print($"max = {arrayDouble[1]}");
            }

            condition = false;
        }
        else
        {
            Print($"Ошибка: некорректное значение -> ({input})");
        }
    }
    else
    {
        Print("Вводимое значение не может быть пустым");
    }
}

static void Print(string resulr)
{
    Console.WriteLine(resulr);
}