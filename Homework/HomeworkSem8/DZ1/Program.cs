// Задайте двумерный массив. Напишите программу, которая
// упорядочивает по убыванию элементы каждой строки двумерного массива.

int[,] CreateRandomArray(int[] arraySize, int minValue = 0, int maxValue = 9)
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
int[,] SortArray(int[,] array)
{
    SortRow(array,0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        SortRow(array,i);
    }
    return array;
}
void SortRow(int[,] array, int rowNumber)
{
    int index = 0;
    int max = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        max = array[rowNumber, i];
        index = i;
        for (int j = i; j < array.GetLength(1); j++)
        {
            if (array[rowNumber, j] > max)
            {
                index = j;
                max= array[rowNumber, j];
            }
        }
        array[rowNumber, index] = array[rowNumber, i];
        array[rowNumber, i] = max;
    }
}
// Script text
int[] sizeArr = new int[2] { 3, 8 };

if (sizeArr[0] > 0 && sizeArr[1] > 0)
{
    int[,] array = CreateRandomArray(sizeArr);
    PrintMatrixArray(array);
    System.Console.WriteLine();
    PrintMatrixArray(SortArray(array));

}
else
{
    System.Console.WriteLine("bad size");
}