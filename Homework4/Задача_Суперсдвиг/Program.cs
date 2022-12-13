Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
for (int i=0; i<n; i++) {
    Console.Write($"Введите {i} элемент массива: ");
    array [i] = Convert.ToInt32(Console.ReadLine());
}
int[] array2 = new int [n];
Console.Write("Введите сдвиг: ");
int sdvig = Convert.ToInt32(Console.ReadLine());
if (sdvig>0) {
for (int j=0; j<n-sdvig;j++){
    array2[j+sdvig]=array[j];
}
for (int j=0; j<sdvig;j++){
    array2[j]=array[n-sdvig+j];
}
}
else {
    for (int j=0; j<n+sdvig;j++){
    array2[j]=array[j-sdvig];
}
for (int j=0; j<-sdvig;j++){
    array2[j+n+sdvig]=array[j];
}
}

Console.WriteLine($"[{string.Join(", ", array2)}]");