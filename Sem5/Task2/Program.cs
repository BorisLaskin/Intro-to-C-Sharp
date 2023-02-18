// Напишите программу замены элементов массива:
// положительные элементы замените на соответствующие
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
int[] ReversePositiveNegative(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = -1 * array[i];
    }
    return newArray;
}
// текст скрипта
int min = -9;
int max = 9;
int number = 12;
int[] array = CreateRandomArray(number, min, max);
System.Console.WriteLine("Исходный массив");
PrintArray(array);
System.Console.WriteLine("Обработанный массив");
PrintArray(ReversePositiveNegative(array));
System.Console.WriteLine("Исходный массив еще раз");
PrintArray(array);

