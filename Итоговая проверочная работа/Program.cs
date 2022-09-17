string[] Array = CreateArray();

string[] CreateArray()
{
    Console.WriteLine("Введите матрицу: ");
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