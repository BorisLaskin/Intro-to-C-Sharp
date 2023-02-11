// Определите, является ли число степенью двойки:
bool Validate(int number)
{
    if (number == 1)
    {
        return true;
    }
    if (number % 2 == 1)
    {
        return false;
    }
    number = number / 2;
    return Validate(number);
}

if (Validate(4))
    System.Console.WriteLine("да");
else
    System.Console.WriteLine("нет");