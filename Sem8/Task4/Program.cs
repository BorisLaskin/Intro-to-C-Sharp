// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
int[,] CreateRandomArray(int[] arraySize, int minValue = -9, int maxValue = 9)
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
int[,] DeleteRowColumn(int[,] array, int ind1, int ind2)
{
    int index1=0;
    int index2=0;
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0);i++)
    {
        if (i != ind1)
        {
            index2=0;
            for (int j = 0; j < array.GetLength(1);j++ )
            {
                if(j!=ind2)
                {
                    newArray[index1,index2]=array[i,j];
                    index2++;
                }
            }
            index1++;
        }
    }
    return newArray;
}
(int, int) FindMinInd(int[,] array)
{
    int ind1 = 0;
    int ind2 = 0;
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                ind1 = i;
                ind2 = j;
            }
        }
    }
    return (ind1, ind2);
}
// Script text
int[] sizeArr = new int[2] { 3, 3 };

if (sizeArr[0] > 0 && sizeArr[1] > 0)
{
    int[,] array = CreateRandomArray(sizeArr);
    PrintMatrixArray(array);
    System.Console.WriteLine();
    (int ind1, int ind2) = FindMinInd(array);
    System.Console.WriteLine($"Минимальный элемент в строке {ind1+1} и столбце {ind2+1}");
    PrintMatrixArray(DeleteRowColumn(array, ind1, ind2));
}
else
{
    System.Console.WriteLine("bad size");
}