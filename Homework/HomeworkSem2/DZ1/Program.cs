// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа. Не использовать строки для расчета.
int InputInt(string massage)
{
    System.Console.WriteLine(massage);
    int x =Convert.ToInt32(Console.ReadLine());
    return x;
}

while(true)
{
    int A=InputInt("Введите трехзначное число");
    if(A>100 && A<1000)
    {
        System.Console.WriteLine($"Вторая цифра числа {A} - это {(A%100)/10}");
        break;
    }
    else System.Console.WriteLine("число нетрехзначное");
}