
void ShowNums(int n)
{
    if (n != 1) ShowNums(n - 1);
    Console.Write($"{n} ");
}

void ShowNumbers(int n, int m)
{
    if (m != n) 
        ShowNumbers(n, m - 1);
        Console.Write($"{m} ");
}

int SummaOfDigitInNumber(int number)
{
    if (number / 10 > 0)
    {
        return number % 10 + SummaOfDigitInNumber(number / 10);
    }
    return number; 
}

int DegreeOfNumber(int number, int degree)
{
    if (degree != 0) return number * DegreeOfNumber(number, degree -1);
    return 1;
}
//Console.WriteLine(DegreeOfNumber(2, 10));

 double GetSumOne(int n)
{
    double sum = 0;
    double i = 1;
    while (i <= n)
    {
        // ReSharper disable once PossibleLossOfFraction
        sum += 1 / i;
        i++;
    }

    return sum;
}

 double GetSumSeven(int n)
        {
            double sqrt = Math.Sqrt(2 + Math.Sqrt(2)); 
            if (n - 1 == 0) return sqrt;
            return 2.0 + GetSumSeven(n - 1);
        }

// Console.WriteLine(Math.Sin(4));
//Console.WriteLine(Math.Sqrt(2 + Math.Sqrt(2)));

 int GetGcdByStein(int a, int b, int c)
        {
                a = a < 0 ? -a : a;
                int[] array = new[] { a, b, c };
                
                for (int i = 1; i < array.Length; i++)
                {
                    b = array[i];
                    b = b < 0 ? -b : b;
                    int divider = 1;
                    while (a > 0 && b > 0)
                    {
                        
                        if ((a & 1) == 0 && (b & 1) == 0)
                        {
                            divider *= 2;
                            a = a >> 1;
                            b = b >> 1;
                        }
                        else if ((a & 1) == 0 && (b & 1) == 0)
                        {
                            a = a >> 1;
                        }
                        else if ((b & 1) == 0 && (a & 1) == 0)
                        {
                            b = b >> 1;
                        }
                        else
                        {
                            if (a >= b)
                            {
                                a -= b;
                            }
                            else
                            {
                                b -= a;
                            }
                        }
                    }

                    a = divider * (a + b);
                }

                return a;
            
        }
Console.WriteLine(GetGcdByStein(15, 5, 45));