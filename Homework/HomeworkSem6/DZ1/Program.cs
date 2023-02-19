// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] IntMassPromt(string message)
{
    System.Console.WriteLine(message);
    string[] strings = Console.ReadLine().Split();
    int[] nums = new int[strings.Length];
    for (int i = 0; i < strings.Length; i++)
        nums[i] = Convert.ToInt32(strings[i]);
    return nums;
}

int CountPositive(int[] array)
{
    int result = 0;
    foreach (int item in array)
    {
        if (item > 0)
            result++;
    }
    return result;
}
// Script text
int[] array = IntMassPromt("Введите M чисел через пробел");
System.Console.WriteLine($"В указанном массиве {CountPositive(array)} элементов больше нуля");