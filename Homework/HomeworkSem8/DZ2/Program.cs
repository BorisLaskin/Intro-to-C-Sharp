// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

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
void PrintRowArray(int[,] array, int number)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        System.Console.Write($"{array[number, j]} ");
    }
    System.Console.WriteLine();
}
int GetMinRowSum(int[,] array)
{
    int number = 0;
    int[] sumOfRows=new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumOfRows[i]+=array[i,j];
        }
    }
    for (int i = 0; i < sumOfRows.Length; i++)
    {
        if (sumOfRows[i]<sumOfRows[number])
        {
            number=i;
        }
    }
    return number;
}

// Script text
int[] sizeArr = new int[2] { 6, 2 };

if (sizeArr[0] > 0 && sizeArr[1] > 0)
{
    int[,] array = CreateRandomArray(sizeArr);
    PrintMatrixArray(array);
    System.Console.WriteLine();
    System.Console.WriteLine("Строка с наименьшей суммой элементов");
    PrintRowArray(array,GetMinRowSum(array));
}
else
{
    System.Console.WriteLine("bad size");
}