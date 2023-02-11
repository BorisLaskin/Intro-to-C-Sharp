// Задайте значения M и N. Напишите программу, которая
// рекурсивно выведет все натуральные числа в промежутке от M до N.
void ShowNumbers(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
    {
        return;
    }
    System.Console.Write($"{firstNumber} ");
    ShowNumbers(firstNumber+1,secondNumber);
    
}

int M=10; int N=20;
if (M>N)
{
    int temp=M;
    M=N;
    N=temp;
}
ShowNumbers(M,N);

