
void FillArray(string[] str, int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Enter {i+1} value of array: ");
        str[i] = Console.ReadLine();
    }
    Console.WriteLine();
}
void PrintArray(string[] str, string massage = "Output given array")
{
    Console.WriteLine(massage);
    int size = str.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(str[i] + " ");
    }
    Console.WriteLine("\n");
}
void SortArray(string[] str)
{
    int size = str.Length;
    for (int i = 0; i < size; i++)
    {
        if(str[i].Length <= 3)
        {
            Console.Write(str[i] + " ");
        }
    }
}

void FinalCase()
{
    Console.Write("Enter length of the array: ");
    int length = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(length);
    string[] array = new string[length];
    FillArray(array, length);
    PrintArray(array);
    Console.WriteLine("Output new sort array");
    SortArray(array);
}
FinalCase();
