// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double Number(string message)
{
   System.Console.WriteLine(message); 
   string param = Console.ReadLine();
   return double.Parse(param);
}
double b1 = Number("Введите число b1: ");
double k1 = Number("Введите число k1: ");
double b2 = Number("Введите число b2: ");
double k2 = Number("Введите число k2: ");
double x = ((b2-b1)/(k1-k2));
System.Console.WriteLine($"Точка пересечения {x}; {k1*x+b1}");

