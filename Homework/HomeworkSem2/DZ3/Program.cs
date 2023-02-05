// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int InputInt(string massage)
{
    System.Console.WriteLine(massage);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int A = InputInt("Введите число->");
if (A > 0 && A < 8)
{
    if (A == 6 || A == 7)
        System.Console.WriteLine("да");
    else
        System.Console.WriteLine("нет");
}
else System.Console.WriteLine("не является днем недели");