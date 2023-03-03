// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30
int RecursionSum(int numberM, int numberN)
{
    if (numberM > numberN)
        return 0;
    return numberM + RecursionSum(numberM + 1, numberN);
}
//Script text
int firstNumber = 4; // проверка на то, что M < N не делается, так как по условию мы их задаем
int endNumber = 8;
if (firstNumber < endNumber)
    System.Console.WriteLine($"Сумма натуральных элементов в промежутке от {firstNumber} до {endNumber} равна {RecursionSum(firstNumber, endNumber)}");
else
    System.Console.WriteLine("Ошибка инициализации начальных значений");