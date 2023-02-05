// See https://aka.ms/new-console-template for more information
// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Hello, World!");
int InputInt(string massage)
{
    System.Console.WriteLine(massage);
    int x =Convert.ToInt32(Console.ReadLine());
    return x;
}
int A=InputInt("Введите первое число->");
int B=InputInt("Введите второе число->");
int res = A%B;
if(res==0) System.Console.WriteLine("кратно");
else System.Console.WriteLine($"некратно, остаток {res} ");