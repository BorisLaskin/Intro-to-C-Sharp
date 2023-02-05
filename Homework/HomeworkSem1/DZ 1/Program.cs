// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите два числа по очереди. Число 1:");
string stringone = Console.ReadLine() ??"";
int numberA = Convert.ToInt32(stringone);
Console.WriteLine("Число 2:");
stringone = Console.ReadLine() ??"";
int numberB = Convert.ToInt32(stringone);
int max=numberA;
int min=numberB;
if(numberA>numberB)
    {
        max = numberA;
        min = numberB;
    }
else
{
    max =numberB;
    min = numberA;
}
Console.WriteLine($"Max is {max}, min is {min}");