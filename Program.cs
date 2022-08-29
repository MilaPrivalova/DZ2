/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Введите количество чисел");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[m];

void NumPositiv(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите {i+1} число: ");
   arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comp(int[] masNumbers)
{
  int count = 0;
  for (int i = 0; i < masNumbers.Length; i++)
  {
    if(masNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

NumPositiv(m);

Console.WriteLine($"Введено чисел больше 0: {Comp(arrayNumbers)} ");