
// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void NumberMoreZiroFromTerminal()  //Важно!! Не приведен метод CultureInfo -> точка это символ, 
                                   //не принадлежит классу цифр. 12,5 - цифра, 12.5- нет
{
    Console.WriteLine($"Enter something number if you wont and press ENTER\n or press ESC and ENTER for exit");
    string input = Console.ReadLine();
    double number;
    int counter = 0;
    string sentence = input;
    while(Double.TryParse(input, out number) != false)  
    {                                           
        if (number > 0) counter ++;
        sentence += " " + input;
        Console.WriteLine("Enter something number if you wont and press ENTER\n or press ESC and ENTER for exit");
        input = Console.ReadLine();     
    }
    
Console.WriteLine($" {sentence}  -> User entered {counter} numbers more then 0 ");
}
NumberMoreZiroFromTerminal();