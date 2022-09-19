Start();
string[] Array = CreateArray();
string str = string.Join(", ", Array);
Console.Write($"[{str}] -> ");
ShortWord(Array);

void Start()
{
    Console.Clear();
    System.Console.WriteLine("Итоговая проверочная работа");
}

string[] CreateArray()
{
    Console.WriteLine("Введите массив: ");
    string? Text = Console.ReadLine();
    Text = Text.Replace(",", "");
    Text = Text.Replace(".", "");

    string[] array = Text.Split(" ");
    string[] ar = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        ar[i] = Convert.ToString(array[i]);
    }
    return ar;
}

void ShortWord(string[] Array)
{
    int max = 3;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= max)
        {
            if (i != Array.Length - 1)
            {
                Console.Write($"{Array[i]}, ");
            }
            else
            {
                Console.Write($"{Array[i]}");
            }
        }
    }
}