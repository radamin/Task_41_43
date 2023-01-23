﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
CrossPoint(k1, b1, k2, b2);

void CrossPoint(double k1, double b1, double k2, double b2)
{
  double x = (b1 - b2) / (k2 - k1);
  double y = (k2 * b1 - k1 * b2) / (k2 - k1);
  if (k1 == k2) Console.Write("The given lines do not intersect!");
  else Console.Write($"Point of intersection of the given lines: ({x}; {y})");
}


