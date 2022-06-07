/*
Задача 1: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.  


Console.Write("Введите первое чиcло: ");
decimal number_1 = Decimal.Parse(Console.ReadLine()); 
Console.Write("Введите второе число: ");
decimal number_2 = Decimal.Parse(Console.ReadLine()); 

if (number_1 > number_2)
{
    Console.WriteLine($"Наибольшее число- {number_1} из чисел {number_1} и {number_2}");
}

if (number_1 == number_2)
{
    Console.WriteLine($"Числа {number_1} и {number_2} равны");
}
else
{
    Console.WriteLine($"Наибольшее число- {number_2} из чисел {number_1} и {number_2}");
}



// принимает число в качестве строки из терминала, преобразует его в число
// (в задании не сказано, какое число придет- выбираем decimal, покрывает максимальный массив чисел в С#),
// присваивает переменной number_1 значение введенного числа.
// .Parse конвертирует только sting  в любой формат.
*/


/* Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.


Console.Write("Введите первое чиcло: ");
decimal number_1 = Decimal.Parse(Console.ReadLine()); 
Console.Write("Введите второе число: ");
decimal number_2 = Decimal.Parse(Console.ReadLine());
Console.Write("Введите первое чиcло: ");
decimal number_3 = Decimal.Parse(Console.ReadLine()); 
decimal max_number = number_1;

if (number_1 == number_2)
{
    if (number_1 == number_3)
    {
        Console.WriteLine($"Числа {number_1} и {number_2} и {number_3} равны");
    }
}
else
{
    if(max_number < number_2)
    {
        max_number = number_2;
    }
    if(max_number < number_3)
    {
        max_number = number_3;
    }
    Console.WriteLine($"Максимальное число из трех чисел {max_number}");
}
*/

/* Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).


Console.Write("Введите чиcло: ");
int number = int.Parse(Console.ReadLine()); 

if (number % 2 != 0)
{
    Console.WriteLine("Число не четное");
}
else
{
     Console.WriteLine("Число четное");
}
*/

/*Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N
*/

Console.Write("Введите чиcло: ");
int number = int.Parse(Console.ReadLine()); 
int counter = 2;

while (counter <= number)
{
    if (counter % 2 == 0)
    {
        Console.Write(counter + ", ");
    }
    counter += 2;
}
Console.WriteLine();
