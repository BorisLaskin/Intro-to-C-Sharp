// Задайте двумерный массив размера m на n, каждый
// элемент в массиве находится по формуле: Aₙₙ = m+n.
// Выведите полученный массив на экран.

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
int[,] CreateFuncArray(int[] arraySize, int minValue = -10, int maxValue = 10)
{
    int[,] numericArray = new int[arraySize[0], arraySize[1]];
   
    for (int i = 0; i < arraySize[0]; i++)
    {
        for (int j = 0; j < arraySize[1]; j++)
        {
            numericArray[i, j] = i+j;
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
// Script text
int[] sizeArr = IntMassInputAndPromt("Введите размерность массива");
if (sizeArr[0] > 0 && sizeArr[1] > 0)
{
    int[,] array = CreateFuncArray(sizeArr);
    PrintMatrixArray(array);
}
else
{
    System.Console.WriteLine("bad size");
}