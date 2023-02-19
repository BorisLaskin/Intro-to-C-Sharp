// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int BinaryPowRank(int number)
{
    int rank = 0;
    while (number > 0)
    {
        rank++;
        number /= 2;
    }
    return rank;
}
int[] MyConvertToBinary(int number)
{
    int[] binArray = new int[BinaryPowRank(number)];
    int i = binArray.Length - 1;
    while (number > 0)
    {
        binArray[i] = number % 2;
        number /= 2;
        i--;
    }
    return binArray;
}
void PrintArray(int[] numericArray)
{
    for (int i = 0; i < numericArray.Length; i++)
    {
        System.Console.Write($"{numericArray[i]} ");
    }
    System.Console.WriteLine();
}
int number = Promt("Введите число >");
System.Console.WriteLine($"Его бинарная форма :");
PrintArray(MyConvertToBinary(number));