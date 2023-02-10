void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0) ; i++)
    {
        for (int j = 0; j < matr.GetLength(1) ; j++)
        {
            System.Console.Write($"-{matr[i, j]}-");
        }
        System.Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
        for (int i = 0; i < matr.GetLength(0) ; i++)
    {
        for (int j = 0; j < matr.GetLength(1) ; j++)
        {
            matr[i,j]=new Random().Next(1,10);
        }
    }
}


string[,] table = new string[2, 5];
table[1, 2] = "слово";

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 5; j++)
    {
        System.Console.Write($"-{table[i, j]}-");
    }
    System.Console.WriteLine();
}

int[,] matrix = new int[3, 4]; // инициализация нулями
PrintArray(matrix);
System.Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
