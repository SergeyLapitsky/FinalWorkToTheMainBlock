string[] initial_array = new string[8] { "Hello", "2", "world", ":-)", "1234", "-2", "Denmark", "Z" };
string[] modified_array = new string[initial_array.Length];

void ModifyInitionArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

ModifyInitionArray(initial_array, modified_array);
PrintArray(modified_array);