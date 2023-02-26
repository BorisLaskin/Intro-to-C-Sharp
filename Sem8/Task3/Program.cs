// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных. Значения элементов массива 0..9

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
(int[,], int[,]) NumberCount(int[,] array)
{
    int[,] naborOfDigits = new int[,] { { 0, 1, 2,3, 4, 5, 6, 7, 8, 9 }};
    int[,] result = new int[1, naborOfDigits.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] >= 0 && array[i, j] < 10)
                result[0, array[i, j]]++;
        }
    }
    return (result, naborOfDigits);
}

// Script text
int[] sizeArr = new int[2] { 3, 4 };

if (sizeArr[0] > 0 && sizeArr[1] > 0)
{
    int[,] array = CreateRandomArray(sizeArr);
    PrintMatrixArray(array);
    System.Console.WriteLine();
    (int[,] digitsCount, int[,] naborOfDigits) = NumberCount(array);
    
    PrintMatrixArray(naborOfDigits);
    PrintMatrixArray(digitsCount);

}
else
{
    System.Console.WriteLine("bad size");
}