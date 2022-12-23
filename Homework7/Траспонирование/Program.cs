Console.Clear();
Console.Write("Введите количество строк массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [n,m];
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
Console.WriteLine();
int [,] array2 = new int [n,m];
for (int i=0; i<array2.GetLength(0); i++) {
    for (int j=0; j<array2.GetLength(1); j++) {
        array2[i,j] = array [array2.GetLength(0)-i-1,j];
        Console.Write($"{array2[i, j]} \t");
    }
    Console.WriteLine();
}
