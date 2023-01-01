Console.Clear();
Console.Write("Введите n: ");
int n=int.Parse(Console.ReadLine());
Console.Write("Введите m: ");
int m=int.Parse(Console.ReadLine());
Console.WriteLine(ack(n,m));
int ack(int n, int m)
{
   if (n == 0)
     return m + 1;
   else if (m == 0)
     return ack (n - 1, 1);
   else
     return ack(n - 1, ack (n, m - 1));
}
