Console.Clear();
Console.Write("Введите количество строк массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] array1 = new int [n,m];
void Matrix (int [,] array) {
int chisla=0;
for (int k=0;k<array.GetLength(0)+array.GetLength(1)-1;k++){
for (int i=0; i<array.GetLength(0); i++) {
    for (int j=0; j<array.GetLength(1); j++) {
        if (i+j==k) { array[i,j] = chisla;
        chisla++;
        }
    }
}}
}
void Matrix2 (int [,] array) {
int chisla=0;
for (int i=0; i<array.GetLength(0); i++) {
    for (int j=0; j<array.GetLength(1); j++) {
        Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}
Matrix(array1);
Matrix2(array1);