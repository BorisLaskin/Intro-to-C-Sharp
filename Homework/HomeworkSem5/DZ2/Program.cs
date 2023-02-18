// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[] CreateRandomArray(int arraySize, int minValue, int maxValue)
{
    int[] numericArray = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        numericArray.SetValue(new Random().Next(minValue, maxValue + 1), i);
    }
    return numericArray;
}
void PrintArray(int[] numericArray)
{
    for (int i = 0; i < numericArray.Length; i++)
    {
        System.Console.Write($"{numericArray[i]} ");
    }
    System.Console.WriteLine();
}
int UnevenPosSum(int[] array)
{
    int sum=0;
    int i=0;
    while(i<array.Length)
    {
        sum+=array[i];
        i+=2;
    }
    return sum;
}

// Основное тело скрипта
int userArrayLength = Promt("Введите длину генерируемого массива (Положительное число) - >");
if (userArrayLength > 0)
{
    int userMinValue = Promt("Введите минимальное значение (Целое число) - >");
    int userMaxValue = Promt("Введите максимальное значение (Целое число) - >");

    if (userMinValue>userMaxValue)
    {
        System.Console.WriteLine("Вы перепутали минимальное и максимальное значения");
        int temp = userMinValue;
        userMinValue = userMaxValue;
        userMaxValue = temp;

    }
    int[] userArray=CreateRandomArray(userArrayLength, userMinValue, userMaxValue);
    PrintArray(userArray);
    System.Console.WriteLine($"Сумма элементов на нечетных позициях {UnevenPosSum(userArray)}");
}
else
    System.Console.WriteLine("Длина массива должна быть положительной");