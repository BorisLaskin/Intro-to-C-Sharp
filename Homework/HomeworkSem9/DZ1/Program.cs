// Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"
void ShowNumbers(int numberM, int numberN)
{
    if (numberM % 2 != 0)
        numberM++;
    if (numberM <= numberN)
    {
        System.Console.Write($"{numberM} ");
        ShowNumbers(numberM + 2, numberN);
    }
    else
    {
        //System.Console.WriteLine("ВСЁ!");
        return;
    }
}
//Script text
int firstNumber = 4; // проверка на то, что M < N не делается, так как по условию мы их задаем
int endNumber = 12;
if (firstNumber <= endNumber)
    ShowNumbers(firstNumber, endNumber);
else
    System.Console.WriteLine("Ошибка инициализации начальных значений");