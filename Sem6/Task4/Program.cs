// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintArray(int[] numericArray)
{
    for (int i = 0; i < numericArray.Length; i++)
    {
        System.Console.Write($"{numericArray[i]} ");
    }
    System.Console.WriteLine();
}
int[] Fibonachi(int number)
{
    int[] result = new int[number];
    result[0] = 0;
    result[1] = 1;
    for (int i = 2; i < result.Length; i++)
    {
        result[i]=result[i-1]+result[i-2];
    }
    return result;
}
//script text
int number = Promt("Введите число >");
PrintArray(Fibonachi(number));