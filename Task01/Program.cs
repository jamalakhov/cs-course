// 1. Напишите программу, которая на вход
// принимает два числа и проверяет, 
// является ли первое число квадратом второго

// Например:
// а = 25, b = 5 -> да
// а = 2, b = 10 -> нет

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
        string[] array = input.Trim().Split(';');

        //Проверяем размер массива
        if (array.Length == 2)
        {
            //Получаем целые числа
            double number;
            int[] arrayInt = new int[2];
            for (int i = 0; i < array.Length; i++)
            {
                //Проверяем возможность конвертации строки в число
                if (double.TryParse(array[i].Trim(), out number))
                {
                    arrayInt[i] = Convert.ToInt32(number);                    
                }
                else
                {
                    Print($"Полученное значение -> ({array[i]}) <- не является числом");
                    myBrake = true;
                    break;
                }
            }

            if (myBrake)
            {
                continue;
            }

            int a = arrayInt[0];
            int b = arrayInt[1];

            if (a == b * b)
            {
                Print("Да");
            }
            else
            {
                Print("Нет");
            }

            condition = false;
        }
        else
        {
            Print($"Введено некорректное значение -> {input}");
        }
    }
    else
    {
        Print("Вводимое значение не может быть пустым");
    }

    static void Print(string result)
    {
        Console.WriteLine(result);
    }
}