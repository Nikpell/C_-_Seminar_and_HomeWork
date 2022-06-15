using System.ComponentModel;
/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом (Палиндро́м (от др.-греч. πάλιν — «назад, снова» и 
др.-греч. δρóμος — «бег, движение»), пе́ревертень[1] — число, буквосочетание, 
слово или текст, одинаково читающееся в обоих направлениях.).


string FunctionIsThatPalindrome(string sentens)
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


Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
Метод работает при подаче координат в скобках через запятую в одну строку (как в примере)
A (7,-5, 0); B (1,-1,9)


double MethodDistanseBetweenTowPoint3D(string enteredSring)
{
string[] coordinaT = enteredSring.Split(new char[]{'(', ')'});
string aPoint = coordinaT[1];
string bPoint = coordinaT[3];
string[] xyz1 = aPoint.Split(new char[]{','});
string[] xyz2 = bPoint.Split(new char[]{','});

int x1 = Convert.ToInt32(xyz1[0]);
int y1 = Convert.ToInt32(xyz1[1]);
int z1 = Convert.ToInt32(xyz1[2]);
int x2 = Convert.ToInt32(xyz2[0]);
int y2 = Convert.ToInt32(xyz2[1]);
int z2 = Convert.ToInt32(xyz2[2]);
   
return Math.Sqrt((x2- x1) * (x2- x1) +(y2- y1) * (y2- y1) + (z2- z1) * (z2- z1));
}
*/

// Блок проверки
Console.Write("Input something: ");
string a = (Console.ReadLine());
Console.WriteLine(MethodDistanseBetweenTowPoint3D(a));

