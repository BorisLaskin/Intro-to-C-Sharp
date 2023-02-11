
System.Console.WriteLine("Введите число");
String stringvalue = Console.ReadLine()?? "";
System.Console.WriteLine(stringvalue);
int value=Convert.ToInt32(stringvalue);

int result = value * value;

Console.WriteLine("квадрат числа " + value + " равен " + result);
Console.WriteLine($"квадрат числа {value} равен {result}");

