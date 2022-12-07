Console.Clear();
Console.WriteLine("Введите количество кустов черники ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество черники на каждом кусте ");
int[] chernika = new int [1000];
int i = 0;
while (i<N)
{
    chernika[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
int[] max = new int [1000];
i = 0;
while (i<N-2) {
    max[i]= chernika[i]+chernika[i+1]+chernika[i+2];
    Console.WriteLine(max[i]);
    i++;
}
i=0;
int[] max2 = {0};
while (i<N-2)
{
    if (max[i]>max[0])
        max2[0] = max[i];
    i++;
}

Console.WriteLine(max2[0]);

