Console.Clear();

Console.WriteLine("Введите координаты точки");

Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoordinate, yCoordinate);
string result = quarter > 0 
                ? $"Указанные координаты соответствуют четверти -> {quarter}" 
                : "Введены некорректные коррдинаты";

System.Console.WriteLine(result);

int Quarter(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}
