
internal class Program
{
    private static void Main(string[] args)
    {
        int[] CreateRandomArray(int size, int min, int max)
        {
            int[] newArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = new Random().Next(min, max + 1);
                Console.Write(newArray[i] + ", ");

            }
            Console.WriteLine();
            return newArray;

        }



        int FindPositiveSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) sum += array[i];
            }
            return sum;
        }

        int FindNegativeSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) sum += array[i];
            }
            return sum;
        }

        int[] ChangSignOfArrayElements(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i] * -1;
            }
            return newArray;
        }

        string NumberInArray(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == number) 
                    {
                        return "Yes";
                    }

           return "No";
        }

        int CounterArray()
        {
            int[] newArrey = new int [12];
            newArrey = CreateRandomArray(12, 10, 1000);
            int counter = 0;
            for (int i = 0; i < newArrey.Length; i++)
            {
                if (newArrey[i] >= 10 && newArrey[i] <= 99 )
                {
                    counter++;
                }
            }
            return counter;
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

        // Блок проверки
        /*
        Console.Write("Input size: ");
        string b1 = Console.ReadLine();
        int a1 = Convert.ToInt32(b1);
        Console.Write("Input min: ");
        string b2 = Console.ReadLine();
        int a2 = Convert.ToInt32(b2);
        Console.Write("Input max: ");
        string b3 = Console.ReadLine();
        int a3 = Convert.ToInt32(b3);
        Console.Write("Input number: ");
        string b4 = Console.ReadLine();
        int a4 = Convert.ToInt32(b4);
*/
        // Console.WriteLine($"New array: [{ArrayToString(ChangSignOfArrayElements(CreateRandomArray(a1, a2, a3)))}]");
        // Console.WriteLine(NumberInArray(CreateRandomArray(a1, a2, a3), a4));
        Console.WriteLine(CounterArray());
    }
}