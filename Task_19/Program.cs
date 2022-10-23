/* Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом. */

int CheckPalindromeNumber(int n)
{
    int n1, n2, n4, n5 = 0;
    n1 = n/10000;
    n2 = n/1000%10;
    n4 = n/10%10;
    n5 = n%10;
    if (n1 == n5 && n2 == n4)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
    Console.WriteLine("Число не является палиндромом");
    } 
    return n;
}

Console.WriteLine(CheckPalindromeNumber(12821));