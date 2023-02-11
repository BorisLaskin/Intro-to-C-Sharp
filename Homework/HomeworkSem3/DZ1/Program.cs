// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int GetNumberRank(int number)
{
    int Rank = 1;
    while (number > 10)
    {
        number = number / 10;
        Rank++;
    }
    return Rank;
}

int testNumber = Promt("Введите положительное число");
if (testNumber > 0)
{
    int numberRank = GetNumberRank(testNumber);
    bool isPolindrome = true;
    while (numberRank > 1)
    {
        var a = testNumber % 10;
        var b = testNumber / Convert.ToInt32(Math.Pow(10, numberRank - 1));
        if (a == b)
        {
            testNumber = testNumber % Convert.ToInt32(Math.Pow(10, numberRank - 1));
            testNumber = testNumber / 10;
            numberRank = numberRank - 2;
        }
        else
        {
            isPolindrome = false;
            break;
        }
    }
    if (isPolindrome)
        System.Console.WriteLine("это полиндром");
    else
        System.Console.WriteLine("нет, это не полиндром");
}
