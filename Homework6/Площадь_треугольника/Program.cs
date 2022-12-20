Console.Clear();
Console.Write("Введите x1,y1,x2,y2,x3,y3 через пробел: ");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
double rast1_2 = Math.Round(Math.Sqrt((Math.Pow(array[2]-array[0],2))+(Math.Pow(array[3]-array[1],2))),2);
double rast1_3 =  Math.Round(Math.Sqrt((Math.Pow(array[4]-array[0],2))+(Math.Pow(array[5]-array[1],2))),2);
double rast2_3 =  Math.Round(Math.Sqrt((Math.Pow(array[4]-array[2],2))+(Math.Pow(array[5]-array[3],2))),2);
double p = (rast1_2+rast1_3+rast2_3)/2;
double S = Math.Round(Math.Sqrt(p*(p-rast1_2)*(p-rast1_3)*(p-rast2_3)),1);
Console.WriteLine(S);