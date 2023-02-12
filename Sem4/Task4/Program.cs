// Напишите программу, которая выводит
// массив из 8 элементов, заполненный нулями и
// единицами в случайном порядке.

int magicNumber = 8;
int[] numericArray = new int[magicNumber];
for (int i = 0; i < numericArray.Length; i++)
{
    numericArray.SetValue(new Random().Next(0,2),i);
    System.Console.Write($"{numericArray[i]}");
}