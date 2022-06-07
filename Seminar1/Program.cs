/*
 Console.Write("Input integer number: ");
 int num = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Result is " + num * num);
*/

/*
Console.Write("Input first integer number: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_2 * num_2 == 0)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}
*/

Console.Write("Input first integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);
while (current <= num)
{
    Console.Write(current + " ");
    current ++;
}
