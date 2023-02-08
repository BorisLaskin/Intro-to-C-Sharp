void FillArray(int[] collection)
{
    int ArrayLength = collection.Length;
    int index = 0;
    while(index < ArrayLength)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}
void PrintArray(int[] collection)
{
    int count = collection.Length;
    int pos = 0;
    while(pos<count)
    {
        System.Console.WriteLine(collection[pos]);
        pos++;
    }
}
int IndexOf(int[] collection,int find)
{
    int Num = collection.Length;
    int index = 0;
    int position = -1;
    while(index < Num)
    {
        if(collection[index]==find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
int find =4;
int pos = IndexOf(array,find);
System.Console.WriteLine($"{find} at {pos}");