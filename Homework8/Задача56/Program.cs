Console.Clear();
Console.Write("Введите количество строк массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [m,n];
void MatrixSet (int[,] array) {
for (int i=0; i<array.GetLength(0); i++) {
    for (int j=0; j<array.GetLength(1); j++) {
        array[i,j] = new Random().Next(0, 11);
    }
}
}
void MatrixPrint (int[,] array) {
for (int i=0; i<array.GetLength(0); i++) {
    for (int j=0; j<array.GetLength(1); j++) {
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}
}
int MatrixMin (int[,] array) {
int [] stroki = new int [array.GetLength(0)];
for (int i=0; i<array.GetLength(0); i++) {
    for (int j=0; j<array.GetLength(1); j++) {
        stroki[i]+=array[i,j];
    }
}
    int min =0;
    for (int i=0; i<stroki.Length; i++) {
        if (stroki[i]<stroki[min]) 
        min=i;
    }
    return min;
}
MatrixSet(array);
MatrixPrint(array);
Console.WriteLine($"{MatrixMin(array)+1} строка");