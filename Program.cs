/*Задача 29: Напишите программу, которая задаёт массив из N элементов,
 заполненных случайными числами из [a, b) и выводит их на экран.*/

 int[] GetArray(int size, int minValue, int maxValue)

{
    int[] rec = new int[size];

    for (int i = 0; i< size; i++)
    {
        rec[i] =  new Random().Next(minValue, maxValue + 1);
    }
    return rec;
}

int[] array = GetArray(3,1,35);
Console.WriteLine(String.Join(" ", array));