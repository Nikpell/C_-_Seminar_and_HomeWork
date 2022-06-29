
/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

double [,] DoubleRandomTwoDimensionalArray(int lines, int columns, int min, int max)
{
    double [,] twoDimensionalArray = new double [lines,columns];

    for (int i = 0; i < lines; i++)
        for (int j = 0; j < columns; j++)
        {
            double value = new Random().NextDouble()* (max - min) + min;
            int temp = Convert.ToInt32(value *100);
            value = Convert.ToDouble(temp) / 100;
            twoDimensionalArray[i,j] = value;
        }
    return twoDimensionalArray;
}

void PrintDoubleTwoDimensionalArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i,j]} ");
        Console.WriteLine();
    }

}


/*Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2

5 9 2 3

8 4 2 4

1 7 -> такого числа в массиве нет
*/

string AnyElementOfTowDemensialArrayIfThereIs(double [,] toDemensionalArray, int line, int column)
{
    if (line >= toDemensionalArray.GetLength(0) || column >= toDemensionalArray.GetLength(1))
    return "That element is absent in array";
    else return $"{toDemensionalArray[line, column]}";
}

/*Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] IntegerRandomTwoDemensionArray(int lines, int columns, int min, int max)
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

double [] AverageOfCollumnInTwoDimensionalArray(int[,] array)
{
    double [] newArray = new double [array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++)
        for (int j = 0; j < array.GetLength(0); j++)
            newArray[i] += Convert.ToDouble(array[j,i]) / array.GetLength(0);

    return newArray;
}
 
string ArrayToString(double[] array)
    {
        string[] arrayString = new string[array.Length];
        string arrayToString = "";

        for (int i = 0; i < array.Length; i++) arrayString[i] = Convert.ToString(array[i]);

        arrayToString = string.Join("; ", arrayString);

        return arrayToString;
    }


/*
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


Console.WriteLine("input something; ");
int e = int.Parse(Console.ReadLine());
Console.WriteLine("Input something:");
int f = int.Parse(Console.ReadLine());
Console.WriteLine();

double [,] testTwoDimensionaleArray = DoubleRandomTwoDimensionalArray(a, b, c, d);
PrintDoubleTwoDimensionalArray(testTwoDimensionaleArray);

Console.WriteLine(AnyElementOfTowDemensialArrayIfThereIs(testTwoDimensionaleArray, e, f));

PrintDoubleTwoDimensionalArray(testTwoDimensionaleArray);

int [,] testTwoDimensionaleArray = IntegerRandomTwoDemensionArray(2, 10, 1, 5);
PrintIntegerRandomTwoDimensionalArray(testTwoDimensionaleArray);
double [] testArray = AverageOfCollumnInTwoDimensionalArray(testTwoDimensionaleArray);
Console.WriteLine(ArrayToString(testArray));
*/
