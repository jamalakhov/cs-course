// 18. Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Clear();

while (true)
{
    Console.Write("Введите номер четверти: ");
    var input = Console.ReadLine();

    if (Int32.TryParse(input, out int quarterNumber))
    {
        string coordinate = GetCoordinate(quarterNumber);
        Console.WriteLine(coordinate);
        return;
    }
    else
    {
        Console.WriteLine($"Ошибка: недопустимый ввод ({input})");
    }
}

string GetCoordinate(int number)
{
    switch(number)
    {
        case 1: 
            return $"Диапазон {number} четверти: x > 0, y > 0";
        case 2:
            return $"Диапазон {number} четверти: x < 0, y > 0";
        case 3:
            return $"Диапазон {number} четверти: x < 0, y < 0";
        case 4:
            return $"Диапазон {number} четверти: x > 0, y < 0";
        default:
            return $"Некорректный номер четверти ({number})";
    }        
}