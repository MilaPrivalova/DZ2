/*Задайте массив заполннный
 случайными положительными трёхзначными числами.
  Напишите программу, которая покажет количество 
  чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int GetArray = new Random().Next(5,6);
int[] array = new int[GetArray];
void FillArr(int[] coll)
{
    int i = 0;
    while(i < coll.Length)
    {
        coll[i] = new Random().Next(99, 1000);
        i++;
    }
    Console.WriteLine("[{0}]", string.Join(", ", coll));
}
int ChetNumbers (int[] array)
{
    int num = 0;
    int i = 0;
    while(i < array.Length)
    {
        if(array[i] % 2 == 0)
        {
            num++;
        }
        i++;
    }
    return num;
}

FillArr(array);
Console.WriteLine($"Четных чисел в  массиве = {ChetNumbers(array)}");