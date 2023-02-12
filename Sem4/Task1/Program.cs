// Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int GetCummulativeSum(int number)
{
    int result=0;
    for (int i = 1; i <= number; i++)
    {
        result+=i;
    }
    return result;
}
int GetCummulativeSumGaus(int number)
{
    
    return (number+1)*number/2;
}
int number = Promt("Введите число");
System.Console.WriteLine($"Куммулятивная сумма числа {number} равна {GetCummulativeSum(number)}");
System.Console.WriteLine($"Куммулятивная сумма числа {number} равна {GetCummulativeSumGaus(number)}");