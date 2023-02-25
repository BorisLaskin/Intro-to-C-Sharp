// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 4

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
void PrintArrayPosition(int[,] array, int[] pos)
{
    if (--pos[0] < array.GetLength(0) && --pos[1] < array.GetLength(1))
    {
        System.Console.WriteLine($"Вы запросили : {array[pos[0], pos[1]]}");
    }
    else
    {
        System.Console.WriteLine("такого числа в массиве нет");
    }

}
// Script text

int[,] array = CreateRandomArray(new int[2] { 3, 4 });
PrintMatrixArray(array);
int[] position = IntMassInputAndPromt("Введите позицию искомого элемента (два числа, через пробел) >");
PrintArrayPosition(array, position);
