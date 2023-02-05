// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
int InputThreeInt()
{
    Console.WriteLine("Введите трехзначное число");
    int x = Convert.ToInt32(Console.ReadLine());
    return x; 
}

int numericdata;
int flag=1;
while (Convert.ToBoolean(flag))
{
    numericdata = InputThreeInt();
    if (numericdata > 99 && numericdata < 1000)
    {
        Console.WriteLine($"третий символ трехзначного числа (разряд единиц) равен {numericdata%10}");
        break;
    }
        
}

