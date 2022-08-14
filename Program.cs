Console.Write("Введите трёхзначное число");
int num = int.Parse(Console.ReadLine());
int result = num/ 10 % 10;
Console.Write($"Вторая цифра числа {num}: {result}");