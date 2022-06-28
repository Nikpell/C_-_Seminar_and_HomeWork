
using System;
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
    {
        for (int j = 0; j < columns; j++)
        {
            double value = new Random().NextDouble()* (max - min) + min;
            int temp = Convert.ToInt32(value *100);
            value = Convert.ToDouble(temp) / 100;
            twoDimensionalArray[i,j] = value;
        }
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

Console.WriteLine("input something: ");
string a1 = Console.ReadLine();
int a = Convert.ToInt32(a1);
Console.WriteLine("input something: ");
string b1 = Console.ReadLine();
int b = Convert.ToInt32(b1);
Console.WriteLine("input something: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input something: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
PrintDoubleTwoDimensionalArray(DoubleRandomTwoDimensionalArray(a, b, c, d));