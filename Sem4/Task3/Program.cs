// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int ShowCumProd(int number)
{
    int result = 1;
    for (int i = 2; i <= number; i++)
    {
        result *= i;
    }
    return result;
}

int number = Promt("Введите положительное число");
if (number > 0)
    System.Console.WriteLine($"Куммулятивное произведение числа {number} равно {ShowCumProd(number)}");
else
    System.Console.WriteLine("Число не положительное");