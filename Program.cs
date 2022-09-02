/*Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.*/

int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows,colums];
FillArray(numbers);
PrintArray(numbers);



// заполнение случайными числами
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.WriteLine("Введите координаты");
 int a = Convert.ToInt32(Console.ReadLine());
 if (a < rows && a < colums)
  return;
Console.WriteLine("такого числа нет");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
