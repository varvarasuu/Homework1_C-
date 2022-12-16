Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
for (int i=0; i< array.Length; i++) {
    array [i] = new Random().Next(-100,101);
}
int summa =0;
Console.WriteLine($"[{string.Join(", ", array)}]");
for (int i=0; i< array.Length; i++) {
    if (i%2==1) {
        summa += array[i];
    }
}
Console.Write(summa);