Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
for (int i=0; i< array.Length; i++) {
    array [i] = new Random().Next(1,32);
}
int [] array4 = new int [n];
int [] array3 = new int [n];
int count4 =0 ;
for (int i=0; i< array.Length; i++) {
    if (array[i]%2==0) {
    array4[i] = array[i];
    count4++;
    }
    else 
    array3[i] = array[i];
}
for (int i=0; i< array.Length; i++) {
    if (array3[i]!=0)
    Console.Write($"{array3[i]} ");
}
Console.WriteLine("");
for (int i=0; i< array.Length; i++) {
    if (array4[i]!=0)
    Console.Write($"{array4[i]} ");
}
Console.WriteLine("");
if (count4>=n-count4) 
Console.Write("YES");
else 
Console.Write("NO");