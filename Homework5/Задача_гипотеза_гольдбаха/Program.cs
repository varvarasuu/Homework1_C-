Console.Clear();
int [] array = new int [998];
int kp =0;
for (int i=3;i<array.Length; i++){
    for (int j=2; j<array.Length; j++)
    {
        if ((i%j==0)&&(i!=j))
        break;
        else 
        array[i]=i;
    }
}
Console.Write("Введите чисо :");
int n = Convert.ToInt32(Console.ReadLine());
for (int i=3;i<array.Length; i++)
{
    for (int j=0; j<array.Length;j++) {
        if (array[i]+array[j]==n){
            Console.Write($"{array[i]}, {array[j]}");
            break;
        }
    }
    
}
