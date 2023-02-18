// Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76
int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
double[] CreateRandomArray(int arraySize, int minValue, int maxValue)
{
    double[] numericArray = new double[arraySize];
    Random rnd = new Random();
    for (int i = 0; i < arraySize; i++)
    {
        numericArray.SetValue(rnd.NextDouble()*(maxValue-minValue)+minValue, i);
    }
    return numericArray;
}
void PrintArray(double[] numericArray)
{
    for (int i = 0; i < numericArray.Length; i++)
    {
        System.Console.Write($"{numericArray[i]} ");
    }
    System.Console.WriteLine();
}
double MinMaxDiv(double[] array)
{
    int minInd = 0;
    int maxInd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minInd])
        {
            minInd = i;
        }
        if (array[i] > array[maxInd])
        {
            maxInd = i;
        }
    }
    return array[maxInd] - array[minInd];
}

// Основное тело скрипта
int userArrayLength = Promt("Введите длину генерируемого массива (Положительное число) - >");
if (userArrayLength > 0)
{
    int userMinValue = Promt("Введите минимальное значение (Целое число) - >");
    int userMaxValue = Promt("Введите максимальное значение (Целое число) - >");

    if (userMinValue > userMaxValue)
    {
        System.Console.WriteLine("Вы перепутали минимальное и максимальное значения");
        int temp = userMinValue;
        userMinValue = userMaxValue;
        userMaxValue = temp;

    }
    double[] userArray = CreateRandomArray(userArrayLength, userMinValue, userMaxValue);
    PrintArray(userArray);

    System.Console.WriteLine($"Разница между максимальным и минимальным элементами равна {MinMaxDiv(userArray)}");
}
else
    System.Console.WriteLine("Длина массива должна быть положительной");