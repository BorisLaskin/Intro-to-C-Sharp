// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе. Реализовать
// через функции.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
bool Validate(int number)
{
    if (number > 0 )
        return true;
    else
        return false;
}
int ShowSumOfDigits(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}
// Основное тело скрипта
int userNumber = Promt("Введите положительное целое число - >");
if (Validate(userNumber))
    System.Console.WriteLine($"Сумма цифр числа : {ShowSumOfDigits(userNumber)}");
else
    System.Console.WriteLine("Число не положительное");