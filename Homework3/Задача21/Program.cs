﻿Console.Clear();
Console.WriteLine("Введите координату х1 ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y1 ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z1 ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату х2 ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y2 ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z2 ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2)), 2);

Console.WriteLine($"Расстояние между точками {distance}");