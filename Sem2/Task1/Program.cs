// See https://aka.ms/new-console-template for more information
int flag=1;
string data="pusto";
int numericdata;
while(Convert.ToBoolean(flag))
{
    Console.WriteLine("Введите трехзначное число");
    data = Console.ReadLine() ??"";
    numericdata=Convert.ToInt32(data);
    if(numericdata>99&&numericdata<1000)
        break;
}

Console.WriteLine($"третий символ трехзначного числа (разряд единиц) равен {data[2]}");