// Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами.
// Оформите заполнение массива и вывод в виде функции(пригодится в следующих задачах). Реализовать через
// функции. (* Доп сложность, “введите количество элементов массива”, “Введите минимальный порог
// случайных значений”, “Введите максимальный порог случайных значений”)
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
bool ValidatePositive(int number)
{
    if (number > 0)
        return true;
    else
        return false;
}
bool ValidateMinLowerMax(int minValue, int maxValue)
{
    if (minValue <= maxValue)
        return true;
    else
        return false;
}
// Основное тело скрипта
int userArrayLength = Promt("Введите длину генерируемого массива (Положительное число) - >");
if (ValidatePositive(userArrayLength))
{
    int userMinValue = Promt("Введите минимальное значение (Целое число) - >");
    int userMaxValue = Promt("Введите максимальное значение (Целое число) - >");

    if (ValidateMinLowerMax(userMinValue, userMaxValue))
        PrintArray(CreateRandomArray(userArrayLength, userMinValue, userMaxValue));
    else
    {
        System.Console.WriteLine("Вы перепутали минимальное и максимальное значения");
        PrintArray(CreateRandomArray(userArrayLength, userMaxValue, userMinValue));
    }
}
else
    System.Console.WriteLine("Длина массива должна быть положительной");