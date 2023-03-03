// Напишите программу, которая заполнит спирально квадратный
// массив.

int[,] SpiralArray(int arraySize = 3)
{
    int[,] spiralArray = new int[arraySize, arraySize];
    int counter = 1;
    int index1 = 0;
    int index2 = 0;
    int directionVertical = 0;
    int directionHorizontal = 1;
    int currentDirection = 1; // 1 вправо, 2 - вниз, 3 - влево, 4 - вверх
    while (counter <= spiralArray.Length)
    {
        if (currentDirection == 0) // выход в случае непредвиденных обстоятельств
            break;

        spiralArray[index1, index2] = counter;
        (directionVertical, directionHorizontal, currentDirection) = ValidateDirection(spiralArray,
        index1, index2, currentDirection);
        
        index1 += directionVertical;
        index2 += directionHorizontal;

        counter++;
    }
    return spiralArray;
}
// проверка возможности заполнения массива при движении в выбранном направлении и изменения направления обхода при необходимости.
(int, int, int) ValidateDirection(int[,] array, int ind1, int ind2, int currentDirection)
{
    switch (currentDirection)
    {
        case 1:
            if (ind2 < array.GetLength(1) - 1 && array[ind1, ind2 + 1] == 0)
                return (0, 1, 1);
            else
                return (1, 0, 2);
        case 2:
            if (ind1 < array.GetLength(0) - 1 && array[ind1 + 1, ind2] == 0)
                return (1, 0, 2);
            else
                return (0, -1, 3);
        case 3:
            if (ind2 > 0 && array[ind1, ind2 - 1] == 0)
                return (0, -1, 3);
            else
                return (-1, 0, 4);
        case 4:
            if (ind1 > 0 && array[ind1 - 1, ind2] == 0)
                return (-1, 0, 4);
            else
                return (0, 1, 1);
        default: break;
    }
    return (0, 0, 0);
}
void PrintMatrixArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            string result = String.Format($"{array[i, j]:d2} ");
            System.Console.Write(result);
        }
        System.Console.WriteLine();
    }
}


// Script text
int size = 5;
int[,] array = SpiralArray(size);
PrintMatrixArray(array);

