// 4. Напишите программу, которая на вход
// принимает три числа и выдает
// максимальное из этих чисел

// Например:
// 22; 3; 9 -> 22

Console.Clear();

bool condition = true;

//Запускаем цикл
while (condition)
{
    bool myBrake = false;

    Console.Write("<----- Введите три числа через символ ';': ");

    var input = Console.ReadLine();

    //Проверяем входящее значение на null
    if (input != null)
    {
        string[] str = input.Trim().Split(';');

        //Проверяем количество введенных значений
        if (str.Length == 3)
        {
            double[] arrayDouble = new double[3];

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
            var max = arrayDouble[0];

            for (int i = 1; i < arrayDouble.Length; i++)
            {
                if (arrayDouble[i] > max)
                {
                    max = arrayDouble[i];
                }
            }

            Print(max.ToString());
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