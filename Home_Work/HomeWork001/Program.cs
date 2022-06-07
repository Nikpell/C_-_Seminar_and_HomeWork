/*
Задача 1: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.  
*/

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



// принимает число в качестве строки из терминала, преобразует его в цельночисленный формат, присваивает 
// переменной number_1 значение введенного числа.
// .Parse конвертирует только sting  в любой формат.
//*/

