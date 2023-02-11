// Напишите программу, которая генерирует последовательность случайных чисел из 10 элементов 
//в диапазоне от 1 до 10, и подсчитывает, сколько сгенерировалось чисел больше 5.
int[] Array=new int[10];
int counter=0;
for (int i = 0; i < Array.Length; i++)
{
    Array.SetValue(new Random().Next(1,10),i);
    System.Console.Write($"{Array.GetValue(i)} ");
    if (Array[i]>5) counter++;
}
System.Console.WriteLine();
System.Console.WriteLine($"Количество сгенерированных чисел больше 5 равно:{counter}");
