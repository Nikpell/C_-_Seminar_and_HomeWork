int[] CreateRandomArray(int size, int min, int max)
    {
        int[] newArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            newArray[i] = new Random().Next(min, max + 1);
           // Console.Write(newArray[i] + ", ");
        }
            Console.WriteLine();
            return newArray;
    }

string ArrayToString(int[] array)
    {
        string[] arrayString = new string[array.Length];
        string arrayToString = "";
        for (int i = 0; i < array.Length; i++)
            {
                arrayString[i] = Convert.ToString(array[i]);
            }
        arrayToString = string.Join(", ", arrayString);
        return arrayToString;
    }

int[] MergeSortArray(int[] array)
{
    int[] newArray = new int[array.Length];
    Console.WriteLine($"[{ArrayToString(array)}]");
    newArray = array;
    int temp = 0;
    for (int i = 1; i < newArray.Length; i += 2)
    //int counter =0;
    {
        if (newArray[i] < newArray[i - 1])  // сравнение 1 уровня
        {
            temp = newArray[i];
            newArray[i] = newArray[i -1];
            newArray[i - 1] = temp; 
        }
    }
    
    int counter = 0;
    int counter2 = 2; 
    

        if (newArray[counter] > newArray[counter2])   // слияние и сравнение первых пар
        {
            temp = newArray[counter];
            newArray[counter] = newArray[counter2];
            if (temp > newArray[counter2 + 1])
            {
                newArray[counter2] = temp;
                temp = newArray[counter + 1];
                newArray[counter + 1] = newArray[counter2 +1];
                newArray[counter2 + 1] = temp;
            }
            else 
            {
                if (newArray[counter + 1] < newArray[counter2 + 1])
                {
                    newArray[counter2] = newArray[counter + 1];
                    newArray[counter + 1] = temp;
                }
                else
                {
                    newArray[counter2] = newArray[counter2 + 1];
                    newArray[counter2 + 1] = newArray[counter + 1];
                    newArray[counter + 1] = temp;
                }
            }

        }
    

    
    Console.WriteLine($"[{ArrayToString(newArray)}]");
    return newArray;
}






    // Блок проверки
  
        Console.Write("Input size: ");
        string b1 = Console.ReadLine();
        int a1 = Convert.ToInt32(b1); 
        Console.Write("Input min: ");
        string b2 = Console.ReadLine();
        int a2 = Convert.ToInt32(b2);
        Console.Write("Input max: ");
        string b3 = Console.ReadLine();
        int a3 = Convert.ToInt32(b3);
 /*  
        Console.Write("Input number: ");
        string b4 = Console.ReadLine();
        int a4 = Convert.ToInt32(b4);
*/
MergeSortArray(CreateRandomArray(a1, a2, a3));
// Console.WriteLine(EvenNumbresOfArray(a1));

// Console.WriteLine(SummaOfElementsOnUnevenPositionInArray(a1, a2, a3));
//Console.WriteLine(DifferenceOfMinimumAndMaximumElementsOfArray(a1, a2, a3));