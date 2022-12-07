Console.Clear();
Console.Write("Введите послеовательность чисел ");
int[] array = new int [100];
int i=0;
while (array[i]<100) {
    array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i]==0)
            break;
    i++;
}
i=1;
int max=array[0];
while (array[i]!=0)
{
    if (array[i]>max)
        max = array[i];
    i++;
}
i=1;
int max2=array[0];
while (array[i]!=0)
{
    if ((array[i]>max2) && (array[i]<max))
        max2 = array[i];
    i++;
}
Console.Write($"Второе по величине число {max2}");

