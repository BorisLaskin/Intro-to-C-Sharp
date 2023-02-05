// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа по очереди. Число 1:");
string stringone = Console.ReadLine() ??"";
int numberA = Convert.ToInt32(stringone);

Console.WriteLine("Число 2:");
stringone = Console.ReadLine() ??"";
int numberB = Convert.ToInt32(stringone);

Console.WriteLine("Число 3:");
stringone = Console.ReadLine() ??"";
int numberС = Convert.ToInt32(stringone);

int max = numberA;

if(numberB>max) max = numberB;
if(numberС>max) max = numberС;

Console.WriteLine($"Максимальное число {max}");
