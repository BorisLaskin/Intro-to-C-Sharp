// See https://aka.ms/new-console-template for more information
// Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры
// нет. Не использовать строки для расчета.

// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

int InputInt(string massage)
{
    System.Console.WriteLine(massage);
    int x =Convert.ToInt32(Console.ReadLine());
    return x;
}
int A=InputInt("Введите число->");
int temp=A;
int result=0;
if(A/100==0) System.Console.WriteLine("третьей цифры нет");
else 
{
    while(temp/100!=0)
    {
        result=temp%10;
        temp=temp/10;
    }
    System.Console.WriteLine($"Третий знак числа {A} - это {result}");
}
    