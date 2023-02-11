// Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[] GetPointCoord()
{
    int[] pointCoord = new int[3];
    pointCoord[0] = Promt("Введите координату X");
    pointCoord[1] = Promt("Введите координату Y");
    pointCoord[2] = Promt("Введите координату Z");
    return pointCoord;
}
double Distance(int[] point1, int[] point2)
{
    var tempA = point1[0] - point2[0];
    var tempB = point1[1] - point2[1];
    var tempC = point1[2] - point2[2];
    return Math.Sqrt(tempA * tempA + tempB * tempB + tempC * tempC);
}
int[] a = { 1, 2, 3 };
var point1 = GetPointCoord();
var point2 = GetPointCoord();
System.Console.WriteLine($"Расстояние между точками = {Distance(point1, point2)}");