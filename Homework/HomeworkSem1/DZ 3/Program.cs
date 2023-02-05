// Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
Console.WriteLine("Является ли целое число четным? Введите целое число:");
string stringOne = Console.ReadLine() ??"";
int number = Convert.ToInt32(stringOne);

if(number%2 == 0)
    Console.WriteLine($"Число {number} четное");
else
    Console.WriteLine($"Число {number} не является четным");