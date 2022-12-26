Console.Clear();
Console.Write("Введите количество строк 1 массива m: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1 массива n: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк 1 массива m: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1 массива n: ");
int n2 = Convert.ToInt32(Console.ReadLine());
while (n1!=m2) {
    Console.WriteLine("Вы не верно указали размеры массива");
    Console.WriteLine("Количество стобцов массива 1 дожно совпадать с количестом строк массива 2");
    Console.WriteLine("Повторите попытку");
    Console.Write("Введите количество строк 1 массива m: ");
    m1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов 1 массива n: ");
    n1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк 1 массива m: ");
    m2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов 1 массива n: ");
    n2 = Convert.ToInt32(Console.ReadLine());
}
int [,] array = new int [m1,n1];
int [,] array2 = new int [m2,n2];
int [,] result = new int [m1,n2];
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
int[,] MatrixMulti (int[,] array, int[,] array2) {
 
for (int k=0; k<array2.GetLength(1); k++) {
    for (int i=0; i<array.GetLength(0); i++){
    for (int j=0; j<array.GetLength(1); j++) {
        result[i,k]+=array[i,j]*array2[j,k];
    }
    }
}
return result;
}
MatrixSet(array);
MatrixPrint(array);
Console.WriteLine();
MatrixSet(array2);
MatrixPrint(array2);
Console.WriteLine();
MatrixPrint(MatrixMulti(array,array2));

