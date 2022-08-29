﻿/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.*/

Console.Write("m= ");
int m = int.Parse(Console.ReadLine());
Console.Write("n= ");
int n = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            result[i, j] = new Random().Next(minValue, maxValue + 1);
    
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int[,] myArray = GetArray(3, 4, 0, 100);
PrintArray(myArray);