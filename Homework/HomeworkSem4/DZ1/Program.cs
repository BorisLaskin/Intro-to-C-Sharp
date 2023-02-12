// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B. Реализовать через функции.
int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int AbsFunction(int number)
{
    if (number > 0)
        return number;
    else
        return -number;
}
double PowFunction(int baseOfDegree, int exponentNumber)
{
    double result = 1;
    for (int i = 0; i < AbsFunction(exponentNumber); i++)
    {
        result *= Convert.ToDouble(baseOfDegree);
    }
    if (exponentNumber > 0)
        return result;
    else
        return 1 / result;
}
// Основное тело скрипта
int userBaseOfDegree = Promt("Введите основание степени (Целое число) - >");
int userExponentNumber = Promt("Введите показатель степени (Целое число)- >");
System.Console.WriteLine($"Результата возведения в степень : {PowFunction(userBaseOfDegree, userExponentNumber)}");