Console.Clear();
Console.Write("Введите строку: ");
string N = Console.ReadLine();
void perestanovka (string N) {
    char k = N[0];
    for (int i=0; i<N.Length-1; i++) {
        N[i]=N[i+1];
    }
    N[N.Length-1]=k;
    Console.WriteLine(N);
    perestanovka(N);
}
perestanovka(N);