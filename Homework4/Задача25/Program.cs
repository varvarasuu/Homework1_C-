Console.Clear();
Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень B: ");
int b = Convert.ToInt32(Console.ReadLine());
int n =1;
for (int i=0; i<b; i++){
    n = n*a;
}
Console.Write($"A в степени B равно: {n}");