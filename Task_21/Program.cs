/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.*/
Console.Write("Введите координату x1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату z1: ");
int z1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату x2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y2: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату z2: ");
int z2 = int.Parse(Console.ReadLine()!);

int A = x2-x1;
int B = y2-y1;
int C = z2-z1;

double distance = Math.Sqrt(A*A+B*B+C*C);

Console.WriteLine(distance);