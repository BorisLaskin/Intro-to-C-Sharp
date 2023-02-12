// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int ShowNumberOfDigits(int number)
{
    int result = 0;
    while (number > 0)
    {
        number /= 10;
        result++;
    }
    return result;
}

int number = Promt("Введите положительное число");
if (number > 0)
    System.Console.WriteLine($"Количество цифр числа {number} равна {ShowNumberOfDigits(number)}");
else
    System.Console.WriteLine("Число не положительное");