// See https://aka.ms/new-console-template for more information
String ReplaceChar(string text, char oldval, char newval)
{
    String result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i]==oldval) result=result + $"{newval}";
        else result= result + text[i];
    }

    return result;
}

String mytext = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";

System.Console.WriteLine(ReplaceChar(mytext,' ','|')) ;