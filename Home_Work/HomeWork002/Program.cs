/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе
 показывает вторую цифру этого числа.

// попытка работы со string 1 вариант

char ThreeDigitNumberHalf (string threeDigit)
{

    char half = Convert.ToChar(threeDigit[1]);
    return half;
}

// второй вариант

int SecondOfThree (int threeDigit)
{
    return threeDigit / 10 % 10;
}
*/
