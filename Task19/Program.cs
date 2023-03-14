// 19. Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
// I
int number = GetNumber("Введите пятизначное число: ");

bool palindrome = IsPalindromeNumber(number);

Console.WriteLine(palindrome ? "да" : "нет");

// II
string numberToString = GetString("Введите число: ");

palindrome = IsPalindromeString(numberToString);

Console.WriteLine(palindrome ? "да" : "нет");

//////////////////////////////////////////////////////////////////
int GetNumber(string message)
{
    while (true)
    {
        Console.Write(message);
        var input = Console.ReadLine();

        if(Int32.TryParse(input, out int number) && number > 9999 && number < 100000)
        {
            return number;            
        }
        else
        {
            Console.WriteLine($"Ошибка: введено недопустимое значение ({input})");
        }        
    }
}

string GetString(string message)
{
    while (true)
    {
        Console.Write(message);
        var input = Console.ReadLine();

        if(Int32.TryParse(input, out int number))
        {
            return number.ToString();            
        }
        else
        {
            Console.WriteLine($"Ошибка: введено недопустимое значение ({input})");
        }        
    }

}

bool IsPalindromeNumber(int number)
{
    int firstDigit = number / 10000;
    int secondDigit = (number / 1000) % 10;
    int thirdDigit = (number / 100) % 10;
    int fourthDigit = (number / 10) % 10;
    int fifthDigit = number % 10;

    return (firstDigit == fifthDigit) && (secondDigit == fourthDigit);
}

bool IsPalindromeString(string input)
{
    for (int i = 0; i < input.Length / 2; i++)
     {
        if (input[i] != input[input.Length - 1 - i])
        {
            return false;            
        }
    }

    return true;
}