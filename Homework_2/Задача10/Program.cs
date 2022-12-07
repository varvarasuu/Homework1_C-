Console.Clear();
Console.Write("Введите трехзначное число ");
int n = Convert.ToInt32(Console.ReadLine());

if ((n/100>=10) || (n < 100) ) 
    Console.WriteLine("Вы ввели не трехзначное число");
else {
    n = n/10;
    n = n%10;
    Console.WriteLine($"Вторая цифра числа {n}");
}