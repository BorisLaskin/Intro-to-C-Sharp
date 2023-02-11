// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр. Использовать рекурсию.

int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int SumOfDigit(int number)
{
    if (number == 0)
        return 0;
    else
    {
        return number%10+SumOfDigit(number/10);
    }
}
int testNumber = Promt("Введите натуральное число");
System.Console.WriteLine($"Сумма цифр {SumOfDigit(testNumber)}");

