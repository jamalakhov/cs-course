// 23. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Clear();

while (true)
{
    Console.Write("Введите число (N): ");    
    var input = Console.ReadLine();

    try
        {
            int result = Int32.Parse(input);

            if(result > 0)
            {
                PrinTable(result);
                return;
            }
            else
            {
                throw new FormatException();
            }            
        }
    catch (FormatException)
        {
            Console.WriteLine($"Введенное значение ({input}) не является целым положительным числом");           
        }    
}

void PrinTable(int input)
{
    for(int i = 1; i <= input; i++)
    {
        double result = Math.Pow(i, 3);
        Console.WriteLine($"{i, 3} | {result, 5}");
    }
}