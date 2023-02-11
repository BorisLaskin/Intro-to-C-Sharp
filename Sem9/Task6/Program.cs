// Проверка на простое число
//Простое число - то, которое делится ТОЛЬКО само на себя и на 1
bool Validate(int number, int devider)
{
    if (devider == 1)
    {
        return true;
    }
    return (number % devider != 0) && Validate(number, devider - 1);
}
bool Starter (int number1)
{
    return Validate (number1,number1-1);
}

System.Console.WriteLine(Starter(31));
