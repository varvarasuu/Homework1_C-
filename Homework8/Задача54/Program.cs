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

int [,] MatrixDecrease (int[,] array) {
    for (int i=0; i<array.GetLength(0); i++) {
        for (int k=0; k<array.GetLength(1)-1; k++){
        for (int j=0; j<array.GetLength(1)-1; j++) {
            if (array[i,j]<array[i,j+1]){
            int temp = array[i,j];
            array[i,j]=array[i,j+1];
            array[i,j+1]=temp;
            }
        } 
        }
    }
    return array;
}

MatrixSet(array);
MatrixPrint(array);
Console.WriteLine();
MatrixPrint(MatrixDecrease(array));
