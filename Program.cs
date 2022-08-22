/*Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную степень B.*/

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int B= Convert.ToInt32(Console.ReadLine());
int result = 1;

  for (int i = 1; i <= B; i++)
{
    result=result*A;
}

Console.WriteLine($"{A} в степени {B} = {result}");
