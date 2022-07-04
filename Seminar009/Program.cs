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
Console.WriteLine(DegreeOfNumber(2, 10));
