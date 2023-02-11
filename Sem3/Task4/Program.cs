// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numberToPow = Promt("Введите натуральное число");
if (numberToPow > 0)
{
    for (int i = 1; i<=numberToPow;i++)
        System.Console.Write($"{Math.Pow(i,2)} ");
}
