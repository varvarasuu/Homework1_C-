Console.Clear();
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [N,N+N-1];
void MatrixSet (int[,] array) {

 for (int i=0; i<array.GetLength(0); i++) 
{   for (int j=0; j<array.GetLength(0)-3;j++){
    array[i,(N+N-2)/2+i]=1;
    array[i,(N+N-2)/2-i]=1;
    if (i>1){
    array[i,((N+N-2)/2+i-2)]=array[i-1,(N+N-2)/2+i-1]+array[i-1,(N+N-2)/2-i+1];
    array[i,((N+N-2)/2-i+2)]=array[i-1,(N+N-2)/2+i-1]+array[i-1,(N+N-2)/2-i+1];
    if (i>3)
    array[i,((N+N-2)/2+i-4)]=6;
    }
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
MatrixSet(array);
MatrixPrint(array);