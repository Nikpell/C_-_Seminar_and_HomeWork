


// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void NumbersMoreZeroFromTerminal()  //Важно!! Не приведен метод CultureInfo -> точка это символ, 
                                   //не принадлежит классу цифр. 12,5 - цифра, 12.5- нет
{
   int counter = 0;
   double number;
   string input = string.Empty;
   string sentence = string.Empty;
   do
   {
    Console.WriteLine($"Enter any number if you want and press ENTER\n or press SPACE and ENTER for exit");
    input = Console.ReadLine();           //при нажатии esc строка смешается вперед, не выводит
    if (Double.TryParse(input, out number)) //первые символы строки (sentence) 
    {
        if (number > 0) counter ++;
        sentence += $"  {Convert.ToString(number)}";
    }
   }while(Double.TryParse(input, out number) != false);
   

    Console.WriteLine($"[{sentence}] -> User entered {counter} numbers more then 0 ");
}

NumbersMoreZeroFromTerminal();

//Напишите программу, которая будет создавать копию заданного массива 
//с помощью поэлементного копирования.

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    //Console.WriteLine(ArrayToString(array));
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
/*
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
// Console.WriteLine(ArrayToString(CopyArray(CreateRandomArray(a1, a2, a3))));