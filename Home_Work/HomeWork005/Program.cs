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

string ForDoubleArrayToString(double[] array)
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

/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
string EvenNumbresOfArray(int size)
{
    int [] arrayOfThreeDigitNumber = new int [size];
    arrayOfThreeDigitNumber = CreateRandomArray(size, 100, 999);
    int counter = 0;

    foreach (int i in arrayOfThreeDigitNumber)
        {
            if (i % 2 == 0) counter++;
               
        }
    return $"[{ArrayToString(arrayOfThreeDigitNumber)}] -> {counter}";
}


/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

string SummaOfElementsOnUnevenPositionInArray(int size, int min, int max)
{
    int[] inArray = new int[size];
    inArray = CreateRandomArray(size, min, max);
    int summa = 0;
    for (int i = 1; i < inArray.Length; i += 2)
    {
        summa += inArray[i];
    }
    return $"[{ArrayToString(inArray)}] -> {summa}";
}

/*
Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

string DifferenceOfMinimumAndMaximumElementsOfArray(int size, int min, int max)
{
    double [] array = new double [size];

    for (int i = 0; i < array.Length; i++ ) array[i] = new Random().NextDouble() * (max - min) + min;
                                                    //создаст вещественный массив как Next(int, int)                          
    double maximumElement = array[0];
    double minimumElement = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (maximumElement < array[i]) maximumElement = array[i];
        if (minimumElement > array[i]) minimumElement = array[i];
    }
    double difference = maximumElement - minimumElement;
    return $"[{ForDoubleArrayToString(array)}] -> {difference}";

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

    // Console.WriteLine(EvenNumbresOfArray(a1));

    // Console.WriteLine(SummaOfElementsOnUnevenPositionInArray(a1, a2, a3));
Console.WriteLine(DifferenceOfMinimumAndMaximumElementsOfArray(a1, a2, a3));