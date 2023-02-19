string[] array = { "one", "two", "three", "four", "five"};
PrintArray(array);
Console.WriteLine();
SortByThree(array);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{1} ", i, array[i]);
    }
}

void SortByThree(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length == 3)
        {
            Console.Write($"{array[i]} ");
        }
        else continue;
    }
}
