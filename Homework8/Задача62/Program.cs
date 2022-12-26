Console.Clear();
int [,] array = new int [4,4];
void MatrixPrint (int[,] array) {
for (int i=0; i<array.GetLength(0); i++) {
    for (int j=0; j<array.GetLength(1); j++) {
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}
}
int i=0, j=0;
while (i!=3 && j!=2){
    int k=0, count=0;
    while (j<array.GetLength(1)-k) {
    array[i,j]=count;
    count++;
    j++;
    if (j==array.GetLength(1)-k-1){
        i=j;
        j=0;
        k++;
    }
    }
    
}
    

