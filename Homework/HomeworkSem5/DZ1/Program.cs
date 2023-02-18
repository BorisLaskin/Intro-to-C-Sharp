// Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве. [345, 897, 568, 234] -> 2

int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[] CreateRandomArray(int arraySize, int minValue, int maxValue)
{
    int[] numericArray = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        numericArray.SetValue(new Random().Next(minValue, maxValue + 1), i);
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
int CountEven(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0)
            count++;
    }
    return count;
}
int min = 100;
int max = 999;
int number = Promt("Введите число элементов массива >");
if (number > 0)
{
    int[] array = CreateRandomArray(number, min, max);
    PrintArray(array);
    System.Console.WriteLine($"Количество четных элементов в массиве равно {CountEven(array)}");
}
else
{
    System.Console.WriteLine("Число элементов должно быть положительным!");
}
