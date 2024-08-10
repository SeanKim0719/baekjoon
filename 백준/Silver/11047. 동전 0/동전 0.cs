var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int N = input[0]; int K = input[1];
int[] coins = new int[N];
int count = 0;
int n = N - 1;
for (int i = 0; i < N; i++)
{
    coins[i] = int.Parse(Console.ReadLine());
}
while (K > 0)
{
    while(K >= coins[n])
    {
        K -= coins[n];
        count++;
    }
    n--;
}
Console.WriteLine(count);