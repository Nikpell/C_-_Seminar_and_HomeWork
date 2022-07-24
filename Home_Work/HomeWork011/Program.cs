internal class Program
{
    private static void Main(string[] args)
    {
        int NextBiggerThan(int number)
        {
            int counter = 1;
            int numberNew = number;
            while (number / 10 > 0)
            {
                counter++;
                number /= 10;
            }
            number = numberNew;
            int[] array = new int[counter];
            for (int i = counter - 1; i >= 0; i--)
            {
                array[i] = number % 10;
                number /= 10;
            }

            Console.WriteLine(ArrayToString(array));
            int pivot = 0, pivot1 = array.Length -1;
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] > array[i - 1])
                {
                    pivot = i;
                    break;
                }
            }
            if (pivot - 1 > 0)
            {
                for (int i = array.Length - 1; i >= pivot; i--)
                {
                    if (array[pivot - 1] < array[i])
                    {
                        pivot1 = i;
                        break;
                    }
                }
            }
            Console.WriteLine(pivot);
            Console.WriteLine(pivot1);

            int[] newArrey = array;
            (newArrey[pivot - 1], newArrey[pivot1]) = (newArrey[pivot1], newArrey[pivot - 1]);
            Console.WriteLine(ArrayToString(newArrey));
            for (int i = pivot, j = newArrey.Length - 1; i < j; i++, j--)
            {
                (newArrey[i], newArrey[j]) = (newArrey[j], newArrey[i]);
            }
            Console.WriteLine(ArrayToString(newArrey));

            for (int i = 0, j = newArrey.Length - 1; i < newArrey.Length; i++, j--)
            {
                number += newArrey[i] * ((int)Math.Pow(10, j));
            }
            return number;

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

        Console.WriteLine(NextBiggerThan(144));
    }
}