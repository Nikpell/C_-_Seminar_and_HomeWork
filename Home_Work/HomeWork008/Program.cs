
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

// сортировка одномерного массива Quick sort

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

string ArrayToString(int [] array)
    {
        string[] arrayString = new string[array.Length];
        string arrayToString = "";

        for (int i = 0; i < array.Length; i++) arrayString[i] = Convert.ToString(array[i]);

        arrayToString = string.Join("; ", arrayString);

        return arrayToString;
    }

    
void qs(int [] array, int first, int last)
{
    if (first < last)
    {
        int left = first, right = last, middle = array[(left + right) / 2];
        do
        {
            while (array[left] < middle) left++;
            while (array[right] > middle) right--;
            if (left <= right)
            {
                int tmp = array[left];
                array[left] =array[right];
                array[right] = tmp;
                left++;
                right--;
            }
        } while (left <= right);
        qs(array, first, right);
        qs(array, left, last);
    }
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
// Console.WriteLine("input maximum number of array: ");
// int d = Convert.ToInt32(Console.ReadLine());


int [] array = CreateRandomArray(10, 0, 9);
Console.WriteLine(ArrayToString(array));
Console.WriteLine();

qs(array, 0, 9);
//Console.WriteLine(ArrayToString(newarray)); 
*/
/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7
*/
int [,] IntegerRandomTwoDemensionArray(int lines, int columns, int min, int max)
{
    int [,] newTwoDimensionalArray = new int[lines, columns];

    for (int i = 0; i < lines; i++)
        for(int j = 0; j < columns; j++) newTwoDimensionalArray[i,j] =
        new Random().Next(min, max + 1);
    return newTwoDimensionalArray;
}

int [] SummaOfLineInTwoDimensionalArray(int[,] array) //вычисляет сумму посторочно, передает в
{                                                     // одномерный массив
    int [] newArray = new int [array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            newArray[i] += (array[i,j]);

    return newArray;
}

void NumberOfStringWhithMinimumSumm(int [] array) // выдает номер строки. Остальные методы вспомога
{                                                 // тельные.
    int minimum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[minimum] > array[i]) minimum = i;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов {minimum + 1}, индекс строки {minimum}");
}


string ArrayToString(int [] array)
    {
        string[] arrayString = new string[array.Length];
        string arrayToString = "";

        for (int i = 0; i < array.Length; i++) arrayString[i] = Convert.ToString(array[i]);

        arrayToString = string.Join("; ", arrayString);

        return arrayToString;
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


int [,] testTwoDimentionalArray = IntegerRandomTwoDemensionArray(3, 6, 0, 9);
PrintIntegerRandomTwoDimensionalArray(testTwoDimentionalArray);
int [] newArray = SummaOfLineInTwoDimensionalArray(testTwoDimentionalArray);
Console.WriteLine(ArrayToString(newArray));
NumberOfStringWhithMinimumSumm(newArray);