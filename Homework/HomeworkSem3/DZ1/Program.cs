// See https://aka.ms/new-console-template for more information
int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int GetNumberRank(int number)
{
    int Rank = 1;
    while (number > 10)
    {
        number / 10;
        Rank++;
    }
    return Rank;
}
int testNumber = Promt("Введите положительное число");
if(testNumber>0)
{
    System.Console.WriteLine(GetNumberRank(testNumber));
}
