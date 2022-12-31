Console.Clear();
Console.Write("Введите M: ");
int m=int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int n=int.Parse(Console.ReadLine());
Console.WriteLine(PrintNumbers(n,m));
 string PrintNumbers(int end, int start)
{
    if (end == start)
    {
        // Console.WriteLine(m);
        return end.ToString();
    }
    string s = PrintNumbers(end, start+1) + ' ' + start.ToString();
    Console.WriteLine(s);
    return (s);
}