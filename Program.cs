Console.Write("Введите любое число");
int number = int.Parse(Console.ReadLine());

if (number > 100)
{
    int result = number / 100 % 10;

    Console.Write($"Третья цифра числа {number}: {result}");

}
else
{
    Console.WriteLine($"в числе {number} третьей цифры нет");

}