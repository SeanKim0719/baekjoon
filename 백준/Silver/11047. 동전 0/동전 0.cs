var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int N = input[0]; int K = input[1];
int[] coins = new int[N];
int count = 0;
for (int i = 0; i < N; i++)
{
    coins[i] = int.Parse(Console.ReadLine());
}
for(int i = N - 1; i >= 0; i--)
{
    count += K / coins[i];
    K %= coins[i];
}
Console.WriteLine(count);