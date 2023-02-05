// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число дня недели");

int number=Convert.ToInt32(Console.ReadLine());
string[] weak = new string[] {"понедельник","вторник","среда","четверг","пятница","суббота","воскресенье"};
if(number>0 && number < 8)
{
    Console.WriteLine($"День недели {weak[number-1]}");
}
else
{
    System.Console.WriteLine("число не соответствует дню недели");
}