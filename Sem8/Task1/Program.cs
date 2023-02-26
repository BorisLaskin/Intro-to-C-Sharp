// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] CreateRandomArray(int[] arraySize, int minValue = -10, int maxValue = 10)
{
    int[,] numericArray = new int[arraySize[0], arraySize[1]];
    Random rnd = new Random();
    for (int i = 0; i < arraySize[0]; i++)
    {
        for (int j = 0; j < arraySize[1]; j++)
        {
            numericArray[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return numericArray;
}
void PrintMatrixArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
void ReplaceFirstLastRows(int[,] array)
{
    if (array.GetLength(0) > 1)
    {
        int temp = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            temp = array[0, i];
            array[0, i] = array[array.GetLength(0) - 1, i];
            array[array.GetLength(0) - 1, i] = temp;
        }
    }
}

// Script text
int[] sizeArr = new int[2] { 3, 4 };

if (sizeArr[0] > 0 && sizeArr[1] > 0)
{
    int[,] array = CreateRandomArray(sizeArr);
    PrintMatrixArray(array);
    System.Console.WriteLine();
    ReplaceFirstLastRows(array);
    PrintMatrixArray(array);

}
else
{
    System.Console.WriteLine("bad size");
}