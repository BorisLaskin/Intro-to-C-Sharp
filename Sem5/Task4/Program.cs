// Задайте одномерный массив из 10 случайных чисел в
// диапазоне от 1 до 200. Найдите количество двузначных элементов
// массива.
// Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
int[] CreateRandomArray(int arraySize, int minValue = 0, int maxValue = 9)
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
int TwoDigitCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (Math.Abs(array[i]) > 9 && Math.Abs(array[i]) < 100)
            count++;
    }
    return count;
}

//текст скрипта

int min = 1;
int max = 200;
int number = 10;
int[] array = CreateRandomArray(number, min, max);
System.Console.WriteLine("Исходный массив:");
PrintArray(array);
System.Console.WriteLine($"Количество двузначных чисел: {TwoDigitCount(array)}");