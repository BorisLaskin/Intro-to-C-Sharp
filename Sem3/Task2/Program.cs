// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).
int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
string GetPossibleCoord(int quorter)
{
    switch (quorter)
    {
        case 1:
            return "xCoord > 0 && yCoord > 0";

        case 2:
            return "xCoord < 0 && yCoord > 0";
        case 3:
            return "xCoord < 0 && yCoord < 0";
        case 4:
            return "xCoord > 0 && yCoord < 0";
        default:
            return "Не является координатной четвертью";
    }

}

var quorter = Promt("Введите Номер координатной плоскости ->");
var message = GetPossibleCoord(quorter);
System.Console.WriteLine(message);