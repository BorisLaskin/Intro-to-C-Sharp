// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[] CreateRandomArray(int arraySize, int minValue = -9, int maxValue = 9)
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
int[] ElementProdArray(int[] array)
{
    int numCounter = 0;
    if (Convert.ToBoolean(array.Length % 2))
        numCounter = array.Length / 2 + 1;
    else
        numCounter = array.Length / 2;
    int[] prodArray = new int[numCounter];
    for (int i = 0; i < numCounter; i++)
    {
        prodArray[i] = array[i] * array[array.Length - i - 1];
        if (i == array.Length - i - 1)
            prodArray[i] = array[i];
    }

    return prodArray;
}
// текст скрипта
int number = Promt("Задайте число элементов массива");
int[] array = CreateRandomArray(number);
System.Console.WriteLine("Исходный массив:");
PrintArray(array);
int[] prodArray = ElementProdArray(array);
PrintArray(prodArray);