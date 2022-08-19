/* Задача 21: Напишите программу, которая принимает 
на вход координаты двух точек и находит расстояние между 
ними в 3D пространстве.*/

Console.Write("Ведите координаты x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Ведите координаты y1: ");
int y1 = int.Parse(Console.ReadLine()); 
Console.Write("Ведите координаты c1 ");
int c1 = int.Parse(Console.ReadLine());
Console.Write("Ведите координаты x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Ведите координаты y2: ");
int y2 = int.Parse(Console.ReadLine()); 
Console.Write("Ведите координаты c2: ");
int c2 = int.Parse(Console.ReadLine()); 
double distanse = Math.Sqrt( Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((c1 - c2), 2));
Console.WriteLine(distanse);
