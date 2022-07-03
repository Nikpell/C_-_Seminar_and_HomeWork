
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
int[,] IntegerRandomTwoDemensionArray(int lines, int columns, int min, int max)
{
    int[,] newTwoDimensionalArray = new int[lines, columns];

    for (int i = 0; i < lines; i++)
        for (int j = 0; j < columns; j++) newTwoDimensionalArray[i, j] =
        new Random().Next(min, max + 1);
    return newTwoDimensionalArray;
}

int[] SummaOfLineInTwoDimensionalArray(int[,] array) //вычисляет сумму посторочно, передает в
{                                                     // одномерный массив
    int[] newArray = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            newArray[i] += (array[i, j]);

    return newArray;
}

void NumberOfStringWhithMinimumSumm(int[] array) // выдает номер строки. Остальные методы вспомога
{                                                 // тельные.
    int minimum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[minimum] > array[i]) minimum = i;
    }
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

void PrintIntegerRandomTwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

/*Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4

12 13 14 5

11 16 15 6

10 9 8 7
*/

int[,] FillingTwoDimensionlMatrixInSpyral(int side)
{
    int sideX = side - 1;
    int sideY = side - 1;
    int number = 1;
    int[,] array = new int[side, side];
    int x = 0;
    int y = 0;
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
//int [,] testTwoDimentionalArray = IntegerRandomTwoDemensionArray(3, 6, 0, 9);
PrintIntegerRandomTwoDimensionalArray(FillingTwoDimensionlMatrixInSpyral(6));
//int [] newArray = SummaOfLineInTwoDimensionalArray(testTwoDimentionalArray);
//Console.WriteLine(ArrayToString(newArray));
//NumberOfStringWhithMinimumSumm(newArray);