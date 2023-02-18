// Задача 2: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[] CreateRandomArray(int arraySize, int minValue, int maxValue)
{
    int[] numericArray = new int[arraySize];
    Random rnd = new Random();
    for (int i = 0; i < arraySize; i++)
    {
        numericArray.SetValue(rnd.Next(minValue, maxValue + 1), i);
    }
    return numericArray;
}
void PrintArray(int[] numericArray)
{
    for (int i = 0; i < numericArray.Length; i++)
    {
        System.Console.Write($"{numericArray[i]} ");
    }
    System.Console.WriteLine();
}
bool ElemFindInArray(int[] array, int element)
{
    foreach (int item in array)
    {
        if (item == element)
            return true;
    }
    return false;
}
string VstavkaNe(bool flag)
{
    if (flag)
        return String.Empty;
    else
        return "не";
}
// текст скрипта
int min = -9;
int max = 9;
int number = 12;
int[] array = CreateRandomArray(number, min, max);
string userStr = "Массив создан, какое число будем искать? >";
int findElement = Promt(userStr);
System.Console.WriteLine("Исходный массив");
PrintArray(array);
System.Console.WriteLine($"Число {findElement} {VstavkaNe(ElemFindInArray(array, findElement))} содержится в массиве");