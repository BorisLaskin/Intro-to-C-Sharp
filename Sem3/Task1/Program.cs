// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и
// выдаёт номер четверти плоскости, в которой находится
// эта точка.

int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
bool ValidateCoordinate(int xCoord, int yCoord)
{
    if (xCoord == 0 || yCoord == 0)
    {
        System.Console.WriteLine("Точка лежит на одной из координатных осей");
        return false;
    }
    return true;
}
int GetQuorter(int xCoord, int yCoord)
{
    if (xCoord > 0 && yCoord > 0) return 1;
    if (xCoord > 0 && yCoord < 0) return 4;
    if (xCoord < 0 && yCoord > 0) return 2;
    else return 3;
}

int x = Promt("Введите X - >");
int y = Promt("Введите Y - >");
if (ValidateCoordinate(x, y))
{
    System.Console.WriteLine($"Для точки ({x},{y}) соответствует '{GetQuorter(x,y)}'- четверть");
}

