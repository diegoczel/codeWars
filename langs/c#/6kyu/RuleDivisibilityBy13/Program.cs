// 
/*
1, 10, 9, 12, 3, 4, sequence of 10 ^ x mod 13

10 ^ 0 % 13 = 1
10 ^ 1 % 13 = 10
10 ^ 2 % 13 = 9
10 ^ 3 % 13 = 12
10 ^ 4 % 13 = 3
10 ^ 5 % 13 = 4

10 ^ 6 % 13 = 1 ... start sequence
*/

// reverse number
// * cada item pela item correspondente da sequence
/* repete até que tenha 2 resultados iguais
    ? analisar se tem loop infinito
*/
Console.WriteLine(Thirt(1234567L));
Console.WriteLine(Thirt(178L));
Console.WriteLine(Thirt(87L));

static long Thirt(long n) 
{
    long[] sequenceDivisibility13 = { 1, 10, 9, 12, 3, 4 };
    string numberReversed = new string(n.ToString().Reverse().ToArray());
    
    long somatorio = 0L;
    for(int index = 0; index < numberReversed.Length; index++)
    {
        somatorio += Convert.ToInt64(numberReversed[index].ToString()) * sequenceDivisibility13[index % sequenceDivisibility13.Length];
    }
    
    if(n == somatorio)
        return n;
    else
        return Thirt(somatorio);
}