Console.WriteLine("Введите числа k1 и b1 уравнения первой прямой через пробел");
double[] line1 = Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();
Console.WriteLine("Введите числа k2 и b2 уравнения второй прямой через пробел");
double[] line2 = Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();


void dot(double[] y1, double[] y2)
{
    double x= (y2[1] - y1[1]) / (y1[0] - y2[0]);
    double y = y1[0] * x + y1[1];
    Console.WriteLine($"Точка пересечения прямых ({x}, {y})");
}

//x = -(b1 - b2) / (k1 - k2); y = k1 * x + b1;
//k1 * x + b1, y = k2 * x + b2
 dot( line1,line2 );
 
