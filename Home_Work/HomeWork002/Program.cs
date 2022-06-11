
/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе
 показывает вторую цифру этого числа. 

// попытка работы со string 1 вариант

char ThreeDigitNumberHalf (string threeDigit)
{
    char nul = threeDigit[0];
    int counter = 0;
    if (nul == '-') counter ++;
    char half = threeDigit[1 + counter];
    return half;
}

// второй вариант

int SecondOfThree (int threeDigit)
{
    if (threeDigit < 0) return threeDigit / 10 % 10 * -1;
    else return threeDigit / 10 % 10;
}

Задача 13: Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.
// 1 решение через строковые методы
Ищем третью слева цифру

string ThirdDigitInNumber (string number)
{
    char nul = number[0];
    int count = 0;
    int lengthNumber = number.Length;

    if (nul == '-')
    {
        count ++;
    }

    if (lengthNumber < (3 + count))
        {
        return "The third Digit is absent";
        
        }
    else 
        {
            string third =  "" + number[2 + count];
            return third;
        }
}

 Ищем третью справа цифру

string ThirdDigitInNumber (string number)
{
    char nul = number[0];
    int count = 0;
    int lengthNumber = number.Length;

    if (nul == '-')
    {
        count ++;
    }

    if (lengthNumber < (3 + count))
        {
        return "The third Digit is absent";
        
        }
    else 
        {
            string third =  "" + number[lengthNumber - 3];
            return third;
        }
}


Second variant
Ищем третью справа цифру

string ThirdDigitInNumberArithmetic (int number)
{
    if (number / 100 != 0)
    {
        if (number > 0 ) 
            {
                return Convert.ToString (number / 100 % 10);
            }
        else return Convert.ToString (number / 100 % 10 * -1);
    }    
    else return "The third Digit is absent";
}

Ищем тртью цифру справа


string ThirdDigitInNumberArithmetic (int number)
{
    if (number / 100 != 0)
    {
        if (number > 0 ) 
            {
                while (number / 1000 > 0)
                {
                    number = number / 10;
                }

                return Convert.ToString (number % 10);
            }
        else 
            {
                number = number * -1;
                while (number / 1000 > 0)
                {
                    number = number / 10; 
                }
                return Convert.ToString (number % 10);
            }
        
    }    
    else return "The third Digit is absent";
}



Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.


string DayOfWeek (string day)
{
    string weekEnd = "Yes, it`s weekend";
    string workingDay = "No, it`s working day";
    switch (day)
    {
        case "6":
            return weekEnd;
            break;
        case "7":
            return weekEnd;
            break;
        default:
            return workingDay;
            break;
    }

}


Блок проверки

Console.Write("Input number: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(ThirdDigitInNumberArithmetic(a));
*/