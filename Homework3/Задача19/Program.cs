Console.Clear();
Console.Write("Введите пятизначное число ");
int n = Convert.ToInt32(Console.ReadLine());
int m1;
int m2;
int m4;
if ((n<10000) || (n>=100000))
    Console.WriteLine("Выввели не пятизначное число");
else {
    m1 = n/10000;
    m2 = n/1000;
    m2 = m2%10;
    m4 = n/10;
    m4 = m4%10;
    if ((m1==n%10) && (m2==m4))
        Console.WriteLine("да");
    else 
        Console.WriteLine("нет");
}