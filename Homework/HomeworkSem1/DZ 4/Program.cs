// Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
int flag = 1;
int number = 0;
while(Convert.ToBoolean(flag))
{
    Console.WriteLine("Найдем все натуральные четные числа меньше/равные N. Введите число N:");
    string stringOne = Console.ReadLine() ??"";
    number = Convert.ToInt32(stringOne);
    if(number>0) flag=0;
    else Console.WriteLine("Вы ввлели ненатуральное число");
}
int count=0;
while(count<number/2)
{
    Console.Write((count+1)*2+" ");
    count++;
}