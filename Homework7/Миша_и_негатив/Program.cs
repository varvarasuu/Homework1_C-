Console.Clear();
Console.Write("Введите количество строк массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
string [,] array1 = new string [n,m];
string [,] array2 = new string [n,m];
void Matrix (string [,] array) {
for (int i=0; i<array.GetLength(0); i++) {
    for (int j=0; j<array.GetLength(1); j++) {
        array[i,j] = Console.ReadLine();
    }
}
}
Console.Write("Введите исходное изображение: ");
Matrix(array1);
Console.Write("Введите Мишен негатив: ");
Matrix(array2);
int count = 0;
for (int i=0; i<array1.GetLength(0); i++) {
    for (int j=0; j<array1.GetLength(1); j++) {
        if (array1[i,j]!=array2[i,j])
        count++;
    }
}
Console.WriteLine(count);
