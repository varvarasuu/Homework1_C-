// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Clear();
Console.Write("Введите количество строк массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double [m,n];
for (int i=0; i<array.GetLength(0); i++) {
    for (int j=0; j<array.GetLength(1); j++) {
        array[i,j] = new Random().NextDouble() * (10 + 10) - 10;
        array[i,j] = Math.Round(array[i,j],2);
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}
Console.Write("Введите количество строку массива i: ");
int i1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбец массива j: ");
int j1 = Convert.ToInt32(Console.ReadLine());
if (i1<array.GetLength(0) && i1>=0) {
if (j1<array.GetLength(1) && j1>=0) 
    Console.Write(array[i1,j1]);
else 
    Console.Write("такой позиции в массиве нет");
}
else 
    Console.Write("такой позиции в массиве нет");