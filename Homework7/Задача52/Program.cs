Console.Clear();
Console.Write("Введите количество строк массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [m,n];
void Matrix (int[,] array) {
for (int i=0; i<array.GetLength(0); i++) {
    for (int j=0; j<array.GetLength(1); j++) {
        array[i,j] = new Random().Next(0, 11);
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}
}
Matrix(array);
double [] sum = new double [n];
double [] mean = new double [n];
 for (int j=0; j<array.GetLength(1); j++){
    for (int i=0; i<array.GetLength(0); i++)
    {sum [j]+= array[i,j];}
    mean [j]= Math.Round(sum[j]/array.GetLength(0),2);
    }
Console.WriteLine($"[{string.Join(", ", mean)}]");
