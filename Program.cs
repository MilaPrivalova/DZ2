Console.Write("Введите число от 1 до 7 обозначающий день недели ");
int num = int.Parse(Console.ReadLine());

if (num == 6 || num == 7)
{
    Console.WriteLine($"{num} Выходной");
}
else
{
    Console.WriteLine($"{num} Рабочий день");
}
