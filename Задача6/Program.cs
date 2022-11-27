Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n%2==0)
    Console.Write("да, число четное");
else 
    Console.Write("нет, число нечетное");