// 40. Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Clear();

int numb1 = ReadeConsole("Введите первую сторону треугольника: ");
int numb2 = ReadeConsole("Введите вторую сторону треугольника: ");
int numb3 = ReadeConsole("Введите третью сторону треугольника: ");

bool result = IsExistTriangle(numb1, numb2, numb3);

Console.WriteLine(result ? "Существует" : "Не существует");

bool IsExistTriangle(int n1, int n2, int n3)
{
    return n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2;
}

int ReadeConsole(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}