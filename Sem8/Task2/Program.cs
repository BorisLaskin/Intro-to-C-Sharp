// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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
int[,] ReplaceRowsAndColumns(int[,] array)
{
    int temp=0;
    //int[,] result = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            temp=array[j, i];
            array[j, i] = array[i, j];
            array[i, j]=temp;
        }
    }
    return array;
}

// Script text
int[] sizeArr = new int[2] { 3, 3 };

if (sizeArr[0] > 0 && sizeArr[1] > 0)
{
    int[,] array = CreateRandomArray(sizeArr);
    PrintMatrixArray(array);
    System.Console.WriteLine();
    PrintMatrixArray(ReplaceRowsAndColumns(array));

}
else
{
    System.Console.WriteLine("bad size");
}