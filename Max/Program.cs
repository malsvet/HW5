// Программа запрашивает у пользователя три числа и выводит на экран максимальное число.

Console.Write("Введите первое число: ");
double a = Double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = Double.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
double c = Double.Parse(Console.ReadLine());
double max;
if (a > b) max = a;
else max = b;
if (c > max) max = c;
Console.Write($"Максимальное число: {max}");
Console.ReadKey();


