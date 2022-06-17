// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int MethodPowerOfNumber(int number, int power)
{
    int powerOfNumber = 1;
    for (int i = 1; i <= power; i++)
        {
            powerOfNumber *= number;
        }
    return powerOfNumber;
}

Console.Write("Input something: ");
string b = (Console.ReadLine());
int number = Convert.ToInt32(b);
Console.Write("Input something: ");
string c = (Console.ReadLine());
int power = Convert.ToInt32(c);
Console.WriteLine(MethodPowerOfNumber(number, power));
