Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (size[0]*size[1]*size[2]>90)
{
Console.WriteLine("Размеры массива превышают допустимое число элементов");
Console.Write("Введите размеры массива: ");
size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int [,,] array = new int [size[0],size[1],size[2]];
void Matrix (int[,,] array) {
    int count=10;
for (int i=0; i<array.GetLength(0); i++) {
    for (int j=0; j<array.GetLength(1); j++) 
    {
        for (int k =0; k<array.GetLength(2); k++) {
            array[i,j,k]=count;
            Console.Write($"{array[i,j,k]}({i},{j},{k})");
            count++;
        }
        Console.WriteLine();
    }
}
}
Matrix(array);