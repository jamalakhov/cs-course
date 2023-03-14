// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();

int inputX1 = GetCoordinate("Введите х1: ");
int inputY1 = GetCoordinate("Введите y1: ");
int inputX2 = GetCoordinate("Введите х2: ");
int inputY2 = GetCoordinate("Введите y2: ");

double distance = GetDistance(inputX1, inputY1, inputX2, inputY2);
double roundDistance = Math.Round(distance, 2, MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между точка координат: {roundDistance}");

////////////////////////////////////////////////////////////////////////
double GetDistance(int x1, int y1, int x2, int y2)
{
    int x = x1 - x2;
    int y = y1 - y2;

    return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
}

int GetCoordinate(string message)
{
    while (true)
    {
        Console.Write(message);
        var input = Console.ReadLine();

        if(Int32.TryParse(input, out int coordinate))
        {
            return coordinate;            
        }
        else
        {
            Console.WriteLine($"Ошибка: введено недопустимое значение ({input})");
        }        
    }
}