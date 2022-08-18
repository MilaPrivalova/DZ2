Console.Write("Введите пятизначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 9999 && number < 100000)
        {
            int a = number % 10;
            int b = number / 10 % 10;
            int c = number / 1000 % 10;
            int d = number / 10000 % 10;
            if (a == d && b == c)
            {
                Console.WriteLine("Число палиндром");
            }
            else
            {
                Console.WriteLine("Число НЕ палиндром");
            }
        }
        else
        {
            {
                Console.WriteLine("Введено неверное число");
            }
        }