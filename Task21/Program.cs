// 21. Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними
// в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

int x1 = GetCoordinate("Введите х1: ");
int y1 = GetCoordinate("Введите y1: ");
int z1 = GetCoordinate("Введите z1: ");
int x2 = GetCoordinate("Введите х2: ");
int y2 = GetCoordinate("Введите y2: ");
int z2 = GetCoordinate("Введите z2: ");

double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));;
double roundDistance = Math.Round(distance, 2, MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между точка координат: {roundDistance}");

////////////////////////////////////////////////////////////////////////
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