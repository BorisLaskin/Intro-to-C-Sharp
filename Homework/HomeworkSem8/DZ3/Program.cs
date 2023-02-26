// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.


// Проверка результата https://matrixcalc.org/ru/

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
int[,] GetMatrixProd(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return result;
}

// Script text


int[,] array1 = CreateRandomArray(new int[] { 2, 3 });
PrintMatrixArray(array1);
System.Console.WriteLine();
int[,] array2 = CreateRandomArray(new int[] { 3, 2 });
PrintMatrixArray(array2);
System.Console.WriteLine();
System.Console.WriteLine("Произведение");
if (array1.GetLength(1) == array2.GetLength(0))
{
    PrintMatrixArray(GetMatrixProd(array1, array2));
}
else
{
    System.Console.WriteLine("Внутренние размеры матриц не совпадают");
}
