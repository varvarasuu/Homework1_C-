Console.Clear();
Console.Write("Введите последовательность чисел через пробел: ");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int CountM (int []array) {
    int count =0;
    foreach(int element in array) {
        if (element >0 )
        count++;
    }
    return count;
}

Console.Write(CountM(array));