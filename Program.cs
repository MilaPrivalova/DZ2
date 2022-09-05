//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.


Console.WriteLine("Введите  первую размерность массива");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  вторую размерность массива");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью размерность массива");
int с = Convert.ToInt32(Console.ReadLine());

if (x < 1 || y < 1 || с < 1 || x * y * с > 180) 
{
    Console.WriteLine("Некорректные значения");
}
else
{
    int[,,] matrix3 = new int[x, y, с];
    int value = 9;
    for (int сIndex = 0; сIndex < с; сIndex++)
    {
        for (int xIndex = 0; xIndex < x; xIndex++)
        {
            Console.Write("\n");
            for (int yIndex = 0; yIndex < y; yIndex++)
            {
                value++;
                if (value > 99)
                {
                    value = -99;
                }
                matrix3[xIndex, yIndex, сIndex] = value;
                Console.Write($"{matrix3[xIndex, yIndex, сIndex]}({xIndex}, {yIndex}, {сIndex}) ");
            }
        }
    }
}
