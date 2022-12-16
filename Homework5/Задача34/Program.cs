Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
for (int i=0; i< array.Length; i++) {
    array [i] = new Random().Next(100,1000);
}
Console.WriteLine($"[{string.Join(", ", array)}]");
int count=0;
for (int i=0; i<array.Length; i++) {
    if (array[i]%2==0)
    count++;
}
Console.WriteLine(count);