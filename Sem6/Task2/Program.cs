// Задача 1: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.
int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
bool Validate(int item)
{
    if (item > 0)
        return true;
    else
        return false;
}
bool ValidateTriangle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
        return true;
    else
        return false;
}
string VstavkaNe(bool flag)
{
    if (flag)
        return String.Empty;
    else
        return "не";
}
// Script text
int firstEdge = Promt("Первая сторона >");
int secondEdge = Promt("Вторая сторона >");
int thirdEdge = Promt("Третья сторона >");
System.Console.WriteLine(
    $"Треугольник с такими сторонами {VstavkaNe(ValidateTriangle(firstEdge, secondEdge, thirdEdge))} существует");
