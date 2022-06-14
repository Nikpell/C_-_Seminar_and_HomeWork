/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом (Палиндро́м (от др.-греч. πάλιν — «назад, снова» и 
др.-греч. δρóμος — «бег, движение»), пе́ревертень[1] — число, буквосочетание, 
слово или текст, одинаково читающееся в обоих направлениях.).
*/

string functionIsThatPalindrome(string sentens)
{
    string[] sentensNew = sentens.Split(' ');
    string newSentens = string.Join("", sentensNew);
    string newSentensLow = newSentens.ToLower();
    char[] newSentensForReverse = newSentensLow.ToCharArray();
    Array.Reverse(newSentensForReverse);
    string newSentensPostReverse = new string(newSentensForReverse);
    if (Equals(newSentensLow, newSentensPostReverse)) return "Yes";
    return "No";
    
}

// Блок проверки
Console.Write("Input something: ");
string a = (Console.ReadLine());
Console.WriteLine(functionIsThatPalindrome(a));

/*

string sentens = "а роза упала на лапу Азора";
string[] sentensNew = sentens.Split(' ');
string newSentens = string.Join("", sentensNew);
string newSentensLow = newSentens.ToLower();
char[] newSentensForReverse = newSentensLow.ToCharArray();
Array.Reverse(newSentensForReverse);
string newSentensPostReverse = new string(newSentensForReverse);

Console.WriteLine(newSentensPostReverse);
*/