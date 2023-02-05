// See https://aka.ms/new-console-template for more information
// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
int[] ToArray(string Number)
{
    int n = Number.Length;
    int i = 0;
    int[] returnArray = new int[n];
    while (i < n)
    {
        char a=Number[i];
        returnArray[i] = Convert.ToInt32(a.ToString());
        i++;
    }
    return returnArray;
}
int MaxEl(int[] array)
{
    int n = array.Length;
    int i = 0;
    int max = array[0];
    while (i < n)
    {
        if (array[i] > max) max = array[i];
        i++;
    }
    return max;
}
int a = new Random().Next(10, 100);

Console.WriteLine($"число {a}, максимальный символ {MaxEl(ToArray(Convert.ToString(a)))}");
