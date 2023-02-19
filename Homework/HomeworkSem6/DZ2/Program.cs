// Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
int[] IntMassPromt(string message)
{
    System.Console.WriteLine(message);
    string[] strings = Console.ReadLine().Split();
    int[] nums = new int[strings.Length];
    for (int i = 0; i < strings.Length; i++)
        nums[i] = Convert.ToInt32(strings[i]);
    return nums;
}
double[] Peresechenie(int[] paramOne,int[] paramTwo)
{
    double[] result=new double[2];
    result[0]=(paramTwo[1]-paramOne[1])/(paramOne[0]-paramTwo[0]);
    result[1]=paramOne[0]*result[0]+paramOne[1];

    return result;
}
//Script text
int[] arrayOne = IntMassPromt("Введите первое коэффициенты уравнения");
int[] arrayTwo = IntMassPromt("Введите первое коэффициенты уравнения");