Console.Clear();

int a = new Random().Next(100,1000);
Console.WriteLine($"Сгенирированное число {a}");
int a1 = a / 100;
int a3 = a % 10;

int b = a1*10 + a3;

Console.Write($"Новое число {b}");