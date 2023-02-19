// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.
int[] CreateRandomArray(int arraySize = 10, int minValue = -9, int maxValue = 9)
{
    int[] numericArray = new int[arraySize];
   Random rnd = new Random();
    for (int i = 0; i < arraySize; i++)
    {
        numericArray.SetValue(rnd.Next(minValue, maxValue + 1), i);
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
int[] CopyArray(int[] array)
{
    int[] result=new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i]=array[i];
    }
    return result;
}
//Script text
int[] sourse=CreateRandomArray();
int[] first =sourse;
int[] second = CopyArray(sourse);
PrintArray(sourse);
PrintArray(first);
PrintArray(second);
sourse[5]=999;
System.Console.WriteLine();
PrintArray(sourse);
PrintArray(first);
PrintArray(second);
