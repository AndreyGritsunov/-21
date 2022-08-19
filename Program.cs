Console.WriteLine("Введите координаты первой точки 1 Х:");
int number1X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки 1 Y:");
int number1Y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки 1 Z:");
int number1Z = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты второй точки 2 Х:");
int number2X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки 2 Y:");
int number2Y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки 2 Z:");
int number2Z = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((number2X - number1X), 2) + Math.Pow((number2Y - number1Y), 2) + Math.Pow((number2Z - number1Z), 2));

Console.WriteLine(result);