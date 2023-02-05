// See https://aka.ms/new-console-template for more information

// Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
// a = 5; b = 25 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> нет
// a = -3 b = 9 -> да

Console.WriteLine("Проверка квадрата числа. Введите два числа по очереди. Первое число (проверяемое):");
string stringOne = Console.ReadLine() ?? "";
int numberA = Convert.ToInt32(stringOne);
Console.WriteLine("Второе число (квадрат проверяемого):");
stringOne = Console.ReadLine() ?? "";
int numberB = Convert.ToInt32(stringOne);

if (numberA * numberA == numberB)
    System.Console.WriteLine($"Число {numberB} является квадратом числа {numberA}");
else System.Console.WriteLine("нет");