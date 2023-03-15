// 19. Напишите программу, которая принимает на вход
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();

long number = GetNumber("Введите число: ");

bool palindrome = IsPalindrome(number);

Console.WriteLine(palindrome ? "да" : "нет");

//////////////////////////////////////////////////////////////////

long GetNumber(string message)
{
    while (true)
    {
        Console.Write(message);
        var input = Console.ReadLine();

        if(Int64.TryParse(input, out long number))
        {
            return number;            
        }
        else
        {
            Console.WriteLine($"Ошибка: введено недопустимое значение ({input})");
        }        
    }
}

bool IsPalindrome(long number)
{    
    if(number < 10) return false;
    
    long origin = number;
    long reversed = 0;
    
    while(number > 0)
    {
        reversed = reversed *10 + number % 10;
        number /= 10;        
    }    

    return origin == reversed;
}
