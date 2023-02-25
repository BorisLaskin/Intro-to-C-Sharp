// Задайте двумерный массив. Найдите элементы, у которых
// обе позиции чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int[] IntMassInputAndPromt(string message)
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
void PowEven(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((i + 1) % 2 == 0 && (j + 1) % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }
        }
    }
}
// Script text
int[] sizeArr = IntMassInputAndPromt("Введите размерность массива");
if (sizeArr[0] > 0 && sizeArr[1] > 0)
{
    int[,] array = CreateRandomArray(sizeArr);
    PrintMatrixArray(array);
    PowEven(array);
    System.Console.WriteLine();
    PrintMatrixArray(array);
}
else
{
    System.Console.WriteLine("bad size");
}