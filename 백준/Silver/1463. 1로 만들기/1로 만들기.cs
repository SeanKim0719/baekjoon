int N = int.Parse(Console.ReadLine());
int[] Dp = new int[3_000_001];
Dp[1] = 0;
for (int i = 2; i <= N; i++)
{
    Dp[i] = Dp[i - 1] + 1;
    if (i % 3 == 0) Dp[i] = Math.Min(Dp[i / 3] + 1, Dp[i]);
    if (i % 2 == 0) Dp[i] = Math.Min(Dp[i / 2] + 1, Dp[i]);
}
Console.WriteLine(Dp[N]);