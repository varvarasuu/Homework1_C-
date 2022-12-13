Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m;
int sum=0;
while (n>0){
    m=n%10;
    sum+=m;
    n/=10;
}
Console.Write($"Сумма цифр в числе равна: {sum}");