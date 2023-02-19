string [] array = {"one", "two", "three", "four", "five"};
PrintArray(array);


void PrintArray (string [] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write("{1} ", i, array[i]);
}
}
