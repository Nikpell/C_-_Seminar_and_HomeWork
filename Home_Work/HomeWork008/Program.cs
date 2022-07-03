
/* Задача 54: Задайте двумерный массив. Напишите программу,
 которая упорядочит по возрастанию элементы каждой строки двумерного массива.
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8
*/

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

int[,]  QuickSortAnyLine (int [,] array, int first, int last, int line)
{
    if (first < last)
    {
        int index = new Random().Next(first, last);
        int left = first, right = last, middle = array[line,index];
        do
        {
            while (array[line, left] < middle) left++;
            while (array[line, right] > middle) right--;
            if (left <= right)
            {
                (array[line, left], array[line, right]) = (array[line, right], array [line, left]);
                left++;
                right--;
            }
        } while (left <= right);
        QuickSortAnyLine(array, first, right, line);
        QuickSortAnyLine(array, left, last, line);
    }
    return array;
}

int [,] QuickSortTwoDimentionalArrayInline(int [,] array)
{
    int first = 0, last = array.GetLength(1) - 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        QuickSortAnyLine(array, first, last, i);  
    }
    return array;
}
/*  
Console.WriteLine("input lines: ");
string a1 = Console.ReadLine();
int a = Convert.ToInt32(a1);
Console.WriteLine("input minimum: ");
string b1 = Console.ReadLine();
int b = Convert.ToInt32(b1);
Console.WriteLine("input maximum: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input maximum number of array: ");
int d = Convert.ToInt32(Console.ReadLine());

int [,] testArray = IntegerRandomTwoDemensionArray(a, b, c, d);
PrintIntegerRandomTwoDimensionalArray(testArray);
Console.WriteLine();
PrintIntegerRandomTwoDimensionalArray(QuickSortTwoDimentionalArrayInline(testArray));
*/
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7
*/

int[] SummaOfLineInTwoDimensionalArray(int[,] array)
{                                                     
    int[] newArray = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++) newArray[i] += (array[i, j]);
            
    return newArray;
}

void NumberOfStringWhithMinimumSumm(int[] array)
{                                                 
    int minimum = 0;
    for (int i = 1; i < array.Length; i++)
        if (array[minimum] > array[i]) minimum = i;
    Console.WriteLine($"Строка с наименьшей суммой элементов {minimum + 1}, индекс строки {minimum}");
}

string ArrayToString(int[] array)
{
    string[] arrayString = new string[array.Length];
    string arrayToString = "";

    for (int i = 0; i < array.Length; i++) arrayString[i] = Convert.ToString(array[i]);

    arrayToString = string.Join("; ", arrayString);

    return arrayToString;
}


/*Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4

12 13 14 5

11 16 15 6

10 9 8 7
*/

int[,] FillingTwoDimensionlMatrixInSpyral(int side, int startsNumber)
{
    int sideX = side - 1, sideY = side - 1, number = startsNumber, x = 0, y = 0;
    int[,] array = new int[side, side];

    while (sideX - x > 0 || sideY - y > 0)
    {
        for (int i = x; i <= sideX; i++) 
        {
            array[y, i] = number;
            number++;
        }
        y += 1;
        for (int i = y; i <= sideY; i++)  
        {
            array[i, sideX] = number;
            number++;
        }
        sideX--;
        for (int i = sideX; i >= x; i--) 
        {
            array[sideY, i] = number;
            number++;
        }
        sideY--;
        for (int i = sideY; i >= y; i--)
        {
            array[i, x] = number;
            number++;
        }
        x++;
    }
    if (side % 2 != 0) array[side /2 , side / 2] = number;
    return array;
}

//Console.WriteLine("input something;");
//int a = Convert.ToInt32(Console.ReadLine());
//int [,] testTwoDimentionalArray = IntegerRandomTwoDemensionArray(4, 10, 0, 9);
//PrintIntegerRandomTwoDimensionalArray(testTwoDimentionalArray);
//PrintIntegerRandomTwoDimensionalArray(FillingTwoDimensionlMatrixInSpyral(6,1));
//int [] newArray = SummaOfLineInTwoDimensionalArray(testTwoDimentionalArray);
//Console.WriteLine(ArrayToString(newArray));
//NumberOfStringWhithMinimumSumm(newArray);
//int [,] testArray = FillingTwoDimensionlMatrixInSpyral(9,10);
//PrintIntegerRandomTwoDimensionalArray(testArray);