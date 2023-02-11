// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.

int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int Power(int a, int n)
{
    if (n == 0)
    {
        return 1;
    }
    return Power(a, n - 1) * a;
}
int baseNumber = Promt("Введите основание");
int powNumber = Promt("Введите степень");
System.Console.WriteLine(Power(baseNumber, powNumber));