Console.Clear();
Console.Write("Введите M: ");
int m=int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int n=int.Parse(Console.ReadLine());
Console.WriteLine(SumNumbers(m,n));
int SumNumbers(int a, int b)
{
    if (a == b+1)
    {
        return 0;
    }
    a += SumNumbers(a+1, b);
    return (a);
}