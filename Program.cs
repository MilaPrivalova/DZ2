/*Напишите функцию и запустите ее, которая принимает на вход 
число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int sum;
int result = 0;

while (num>0)
{
    sum = num%10;
    num = num/10;
    result = result+sum;
}
Console.WriteLine(result);



