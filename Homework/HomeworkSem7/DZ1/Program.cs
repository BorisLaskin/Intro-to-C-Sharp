// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.

int[] InputIntMassAndPromt(string message)
{
    while (true)
    {
        System.Console.WriteLine(message);
        string tempString = Console.ReadLine() ?? String.Empty;
        string[] strings = tempString.Split();
        if (strings.Length == 2)
        {
            int[] nums = new int[strings.Length];
            for (int i = 0; i < strings.Length; i++)
                nums[i] = Convert.ToInt32(strings[i]);
            return nums;
        }
        System.Console.WriteLine("Вы ввели не 2 числа.Попробуй снова.");
    }
}
double[,] CreateRandomArray(int[] arraySize, int minValue = -10, int maxValue = 10)
{
    double[,] numericArray = new double[arraySize[0], arraySize[1]];
    Random rnd = new Random();
    for (int i = 0; i < arraySize[0]; i++)
    {
        for (int j = 0; j < arraySize[1]; j++)
        {
            numericArray[i, j] = rnd.NextDouble()*(maxValue-minValue)+minValue;
        }
    }
    return numericArray;
}
void PrintMatrixArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{Math.Round(array[i, j], 2)} ");
        }
        System.Console.WriteLine();
    }
}
// Script text
int[] sizeArr = InputIntMassAndPromt("Введите размерность массива (два числа, через пробел)");
if (sizeArr[0] > 0 && sizeArr[1] > 0)
{
    double[,] array = CreateRandomArray(sizeArr);
    PrintMatrixArray(array);
}
else
{
    System.Console.WriteLine("bad size");
}