// See https://aka.ms/new-console-template for more information
//Поиск всех комбинаций слов из афавита длинной N
int n = 1;
void FindAllWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        System.Console.WriteLine($"{n++} {new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindAllWords(alphabet, word, length+1);
    }
}
FindAllWords("абвг",new char[2]);
