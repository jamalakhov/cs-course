﻿// 1. Напишите программу, которая на вход
// принимает два числа и проверяет, 
// является ли первое число квадратом второго

// Например:
// а = 25, b = 5 -> да
// а = 2, b = 10 -> нет

bool condition = true;


Console.Clear();

//Запускаем цикл
while (condition)
{
    bool myBrake = false;
    Console.Write("<----- Введите два числа через пробел: ");

    var input = Console.ReadLine();

    //Проверяем входящее значение на null
    if (input != null)
    {
        string[] array = input.Trim().Split(' ');

        //Проверяем размер массива
        if (array.Length == 2)
        {
            //Получаем целые числа
            double number;
            int[] arrayInt = new int[2];
            for (int i = 0; i < array.Length; i++)
            {
                //Проверяем возможность конвертации строки в число
                if (double.TryParse(array[i], out number))
                {
                    arrayInt[i] = Convert.ToInt32(number);
                }
                else
                {
                    Console.WriteLine($"Полученное значение -> ({array[i]}) <- не является числом");
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
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }

            condition = false;
        }
        else
        {
            Console.WriteLine($"Введено некорректное значение -> {input}");
        }
    }
    else
    {
        Console.WriteLine("Вводимое значение не может быть пустым");
    }
}