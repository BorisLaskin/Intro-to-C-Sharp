// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N при помощи рекурсии.
void ShowNumbers(int number)
{
    if (number == 0)
    {
        return;
    }
    ShowNumbers(number-1);
    System.Console.Write($"{number} ");
}
ShowNumbers(5);