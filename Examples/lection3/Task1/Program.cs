// See https://aka.ms/new-console-template for more information
void Method1()
{
    System.Console.WriteLine("Это текст");
}
void Method2(string massage)
{
    System.Console.WriteLine(massage);
}
void Method21(string massage, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(massage);
        i++;
    }
}
int Method3()
{
    return DateTime.Now.Year;

}
Method1();
Method2("Приветственный текст на заказ!");
Method21("Привет!", count: 4);
System.Console.WriteLine(Method3());
Method4(4); // Метод писать можно где -угодно!!!!
int Method4(int Count)
{
    for(int i=1;i<=Count;i++)
    {
        for (int j = 1; j <= Count; j++)
        {
            System.Console.Write(i*j+" ");
        }
        System.Console.Write('\n');
    }
    return 0;
}