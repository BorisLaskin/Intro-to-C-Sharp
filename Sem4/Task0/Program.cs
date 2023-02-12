// Напишите программу, которая выводит
// первые заданные элемента следующей
// последовательности:
// -> 12
// 1 2 2 3 3 3 4 4 4 4 5 5
int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
void ShowSequence(int number)
{

    int currentNumber = 1;
    int currentNumberPrinted = 0;
    for (int i = 0; i < number; i++)
    {
        if (currentNumberPrinted == currentNumber)
        {
            currentNumberPrinted = 0;
            currentNumber++;
        }

        System.Console.Write($"{currentNumber} ");
        currentNumberPrinted++;
    }
    return;
}
bool Validate(int number)
{
    if (number > 0)
        return true;
    else return false;
}
int SequenceNum = Promt("Сколько элементов последовательности вы желаете увидеть? ->");
if (Validate(SequenceNum)) ShowSequence(SequenceNum);

