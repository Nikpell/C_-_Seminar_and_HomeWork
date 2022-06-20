
/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

string MethodPowerOfNumber(int number, int power)
{   
    int powerOfNumber = 1;
    if (power <= 0) return "You entered a non-natural number. Function works only for natural exponent";
    for (int i = 1; i <= power; i++)
        {
            powerOfNumber *= number;
        }
    return $"{powerOfNumber}";
}


/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19, 3, 44, 3 -> [1, 2, 5, 7, 19, 3, 44, 3]


string  MethodWriteRandomArray()
{
 //   int [] array = new int[8];               // снять комментарий, если нужен числовой массив
    var element = new Random();              // блок 1
    int i = 0;
    string[] result = new string[8]; 
/*    блок 1
    while (i < array.Length)
    {
        array[i] = element.Next(101);
        i++;

    }

    string[] result = new string[8];                  // использовать если нужен числовой массив
    i = 0;                                            // блок 1 не используется
    while (i < array.Length)
    {
        result[i] = Convert.ToString(array[i]);
        i++;

    }
конец блока 1
*/ 
/*

  // рабочий блок 
    while (i < result.Length)
    {
        result[i] = Convert.ToString(element.Next(101));  // строковый массив
        i++;

    }
    
    string resultNew = String.Join(", " , result);
    return $"{resultNew} -> [{resultNew}]";              // вывод как в примере
}


Console.WriteLine(MethodWriteRandomArray());

*/