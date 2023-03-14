// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.Clear();

int xCoordinate = GetCoordinate("Введите координат x: ");
int yCoordinate = GetCoordinate("Введите координат y: ");
int quarter = GetQuarter(xCoordinate, yCoordinate);

PrintResult(quarter);

//////////////////////////////////////////////////////////
int GetQuarter(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

int GetCoordinate(string message)
{
    while (true)
    {
        Console.Write(message);
        var input = Console.ReadLine();

        if(Int32.TryParse(input, out int coordinate) && coordinate != 0)
        {
            return coordinate;            
        }
        else
        {
            Console.WriteLine($"Ошибка: введено недопустимое значение ({input})");
        }        
    }
}

void PrintResult(int quarter)
{
    string result = quarter > 0 
                ? $"Указанные координаты соответствуют четверти -> {quarter}"
                : "Введены некорректные координаты";

    Console.WriteLine(result);
}