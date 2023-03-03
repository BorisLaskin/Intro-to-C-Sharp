// Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int Ankerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return Ankerman(m-1, 1);
    }
    else
    {
        return Ankerman(m-1, Ankerman(m, n-1));
    }

}
//Script text
int firstNumber = 3;
int secondNumber = 2;
if (firstNumber >= 0 && secondNumber >= 0)
    System.Console.WriteLine($"A({firstNumber},{secondNumber}) = {Ankerman(firstNumber, secondNumber)}");
else
    System.Console.WriteLine("Ошибка инициализации начальных значений");