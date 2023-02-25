// Задайте двумерный массив. Введите элемент, и найдите
// первое его вхождение, выведите позиции по горизонтали и
// вертикали, или напишите, что такого элемента нет.

// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.

// Задайте двумерный массив. Найдите максимальный
// элемент массива и среднее арифметическое всех элементов
// массива.

// Максимальный элемент массива 9
// Среднее арифметическое 4.25

int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
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
(int, int) FindElementArray(int[,] array, int toFind)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == toFind)
            {
                return (i, j);
            }
        }
    }
    return (-1, -1);
}
(int, double) MaxAverageMatrix(int[,] array)
{
    int max = array[0, 0];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > max)
            {
                max = array[i, j];
            }
            sum+=array[i, j];
        }
    }
    double average = Convert.ToDouble(sum)/(array.GetLength(0)*array.GetLength(1));
    return (max,average);
}
// Script text
int[] sizeArr = IntMassInputAndPromt("Введите размерность массива >");
if (sizeArr[0] > 0 && sizeArr[1] > 0)
{

    int[,] array = CreateRandomArray(sizeArr);
    PrintMatrixArray(array);
    int toFindData = Promt("Введите искомое значение >");

    (int x, int y) = FindElementArray(array, toFindData);

    if (x == -1)
        System.Console.WriteLine($"Введенный элемент {toFindData}, результат: такого элемента нет");
    else
        System.Console.WriteLine($"Введенный элемент {toFindData}, результат: [{x + 1},{y + 1}]");

    (int max, double average) = MaxAverageMatrix(array);
    System.Console.WriteLine($"Максимальный элемент {max}, Среднее арифметическое {average}");
}
else
{
    System.Console.WriteLine("bad size");
}