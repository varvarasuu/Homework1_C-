Console.Clear();
Console.Write("Введите число N ");
double N = Convert.ToDouble(Console.ReadLine());
double i=1;
while (i<=N)
{
    Console.Write($"{Math.Pow(i,3)} ");
    i++;
}