Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double [] array = new double [n];
for (int i=0; i< array.Length; i++) {
    array [i] = new Random().Next(-100,101);
}
Console.WriteLine($"[{string.Join(", ", array)}]");
double max =0;
double min = 101;
for (int i=0; i< array.Length; i++) {
    if (array[i]>max) 
    max = array[i];
}
for (int i=0; i< array.Length; i++) {
    if (array[i]<min) 
    min = array[i];
}

Console.Write(max-min);