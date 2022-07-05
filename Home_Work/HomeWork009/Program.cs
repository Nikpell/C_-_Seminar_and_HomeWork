
/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
 натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int SummaOfNumberReccursion(int start, int end)
{
    if(start == end) return end;   
    return end + (SummaOfNumberReccursion(start, end - 1));
}

/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.

453 -> 3

45 -> 2
*/
int AmountDigitInNumber(int number)
{
    if (number / 10 == 0) return 1;
    return number/number + AmountDigitInNumber(number / 10) ;  
}


Console.WriteLine(AmountDigitInNumber(9000));