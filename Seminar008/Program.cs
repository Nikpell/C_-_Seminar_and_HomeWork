

int [,] IntegerRandomTwoDemensionArray(int lines, int columns, int min, int max)
{
    int [,] newTwoDimensionalArray = new int[lines, columns];

    for (int i = 0; i < lines; i++)
        for(int j = 0; j < columns; j++) newTwoDimensionalArray[i,j] =
        new Random().Next(min, max + 1);
    return newTwoDimensionalArray;
}

void PrintIntegerRandomTwoDimensionalArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        Console.Write($"{array[i,j]} ");
    Console.WriteLine();
    } 
}

int[,] ChangeLinesInTwoDimentionalArray(int [,] array, int strIndex1, int strIndex2)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        temp = array[strIndex1, i];
        array [strIndex1, i] = array [strIndex2, i];
        array [strIndex2, i] = temp; 
    }
    return array; 
}

// перенос строки в столбец в двухмерном массиве

int [,] TransferLinesToColumns(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i + 1; j < array.GetLength(0); j++)
        {
            temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }       
    }
    return array;
}

// нахождение индекса минимального элемента

int [] IndexOfElementWhithMinimumValue(int[,] array)
{
    int elementWhithMinimumValue = array [0,0];
    int [] index = new int [2];
    
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            if (elementWhithMinimumValue > array [i, j])
            {
                index [0] = i;
                index [1] = j;
                elementWhithMinimumValue = array [i, j];
            } 
        }
    }
    return index;

}

string ArrayToString(int [] array)
    {
        string[] arrayString = new string[array.Length];
        string arrayToString = "";

        for (int i = 0; i < array.Length; i++) arrayString[i] = Convert.ToString(array[i]);

        arrayToString = string.Join("; ", arrayString);

        return arrayToString;
    }

// замена строки и столбца с минимальным элементом на 0 
int [,] ChangeLineAndColumnWhithMinimumElementToZero(int [,] array, int [] index)
{
    for (int i = 0; i < array.GetLength(1); i++) array[index[0], i] = 0;
    for (int i = 0; i < array.GetLength(0); i++) array[i, index[1]] = 0;
    return array;
}



Console.WriteLine("input lines: ");
string a1 = Console.ReadLine();
int a = Convert.ToInt32(a1);
Console.WriteLine("input columns: ");
string b1 = Console.ReadLine();
int b = Convert.ToInt32(b1);
Console.WriteLine("input minimum number of array: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input maximum number of array: ");
int d = Convert.ToInt32(Console.ReadLine());
/*
Console.WriteLine("input something; ");
int e = int.Parse(Console.ReadLine());
Console.WriteLine("Input something:");
int f = int.Parse(Console.ReadLine());
Console.WriteLine();
*/

int [,] testArrey = IntegerRandomTwoDemensionArray(a, b, c, d);
PrintIntegerRandomTwoDimensionalArray(testArrey);
Console.WriteLine();
int [] index = IndexOfElementWhithMinimumValue(testArrey);
Console.WriteLine(ArrayToString(IndexOfElementWhithMinimumValue(testArrey)));
Console.WriteLine();
int [,] modifiedArrey = ChangeLineAndColumnWhithMinimumElementToZero(testArrey, index);
PrintIntegerRandomTwoDimensionalArray(modifiedArrey);

