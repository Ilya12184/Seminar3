/*Напишите программу, которая принимает на вход число (N) 
и выдает таблицу простых чисел от 1 до N.*/

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int number = 0;
for (int i = 0; i < N; i++)
{
    if (number == 1) number++;
    if (number == 2) Console.Write($"{number} ");
    if (number == 3) Console.Write($"{number} ");
    if (number == 5) Console.Write($"{number} ");
    if (number == 7) Console.Write($"{number} ");
    if (number%2 != 0 && number%3 != 0 && number%5 != 0 && number%7 != 0)
    {
        Console.Write($"{number} ");
        number++;
    }
    else
    {
        number++;
    }
}
return number;