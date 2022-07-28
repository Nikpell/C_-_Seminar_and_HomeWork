int GetArrayLenght(string?[] array, int lenght)
{
    int counter = 0;
    int i = 0;
    while (i < array.Length)
    {
        if (array[i]!.Length <= lenght)
        {
            if (array[i]!.Length > 0)
            {
                counter++;
            }
        }
        i++;
    }
    return counter;
}

string?[] GetNewArray(string?[] array, int counter, int lenght)
{
    string?[] result = new string?[counter];
    int i = 0;
    int j = 0;
    while (i < array.Length)
    {
        if (array[i]!.Length <= lenght)
        {
            if (array[i]!.Length > 0)
            {
                result[j] = array[i];
                j++;
            }
        }

        i++;
    }
    return result;

}



void PrintStringArray(string?[] array)
{
    string forPrint = "[";
    if (array.Length == 0)
    {
        forPrint = "[]";
    }
    else
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            forPrint += $"\"{array[i]}\", ";
            //Console.WriteLine(array[i]);
        }
        forPrint += $"\"{array[^1]}\"]";
    }

    Console.WriteLine(forPrint);
}

string?[] EnterArrayFromKeyboard()
{
    Console.WriteLine("How many words would you like to enter?\nEnter numbers of words:  ");
    var lenght = Console.ReadLine();
    if (int.TryParse(lenght, out var intLenght))
    {
        string?[] array = new string? [intLenght];
        for (int i = 0; i < intLenght; i++)
        {
            Console.WriteLine($"Enter word {i + 1}:  ");
            array[i] = Console.ReadLine();
        } 
        return array;
    }

    else return Array.Empty<string>();
}

string?[] array = EnterArrayFromKeyboard();
int lenght = 3;
int counter = GetArrayLenght(array, lenght);
PrintStringArray(array);
PrintStringArray(GetNewArray(array, counter, lenght));
