// Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
double[] IntMassPromt(string message)
{
    System.Console.WriteLine(message);
    string[] strings = Console.ReadLine().Split();
    double[] nums = new double[strings.Length];
    for (int i = 0; i < strings.Length; i++)
        nums[i] = Convert.ToDouble(strings[i]);
    return nums;
}
double[] Peresechenie(double[] paramOne,double[] paramTwo)
{
    double[] result=new double[2];
    result[0]=(paramTwo[0]-paramOne[0])/(paramOne[1]-paramTwo[1]);
    result[1]=paramOne[1]*result[0]+paramOne[0];

    return result;
}
void PrintArray(double[] numericArray)
{
    for (int i = 0; i < numericArray.Length; i++)
    {
        System.Console.Write($"{numericArray[i]} ");
    }
    System.Console.WriteLine();
}
//Script text
double[] arrayOne = IntMassPromt("Введите b k коэффициенты первого уравнения через пробел >");
double[] arrayTwo = IntMassPromt("Введите b k коэффициенты второго уравнения через пробел >");
double[] result = Peresechenie(arrayOne,arrayTwo);
PrintArray(result);
