// Задача 1: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

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
// текст скрипта
int min = -9;
int max = 9;
int number = 12;
int[] array = CreateRandomArray(number, min, max);
PrintArray(array);
int sumPositive = 0;
int sumNegative = 0;
foreach (int item in array)
{
    if (item>0)
    {
        sumPositive+=item;
    }
    else
    {
        sumNegative+=item;
    }
}
System.Console.WriteLine($"Сумма положительных элементов: {sumPositive}\nСумма отрицательных элементов: {sumNegative}");