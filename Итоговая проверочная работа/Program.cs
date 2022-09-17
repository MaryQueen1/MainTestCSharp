Start();
string[] Array = CreateArray();
ShortWord(Array);

void Start()
{
    Console.Clear();
    System.Console.WriteLine("Итоговая проверочная работа");
}

string[] CreateArray()
{
    Console.WriteLine("Введите длину массива: ");
    int Length = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < Length - 1; i++)
    {
        System.Console.WriteLine($"Введите {i + 1} набор символов: ");
        string? Array[i + 1]
    }
}

void ShortWord(string[] Array)
{
    int max = 3;
    for (int i = 0; i < Array.Length; i++)
    {

    }
}