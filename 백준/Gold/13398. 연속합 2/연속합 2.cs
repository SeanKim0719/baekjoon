int n = int.Parse(Console.ReadLine());
var list = Console.ReadLine().Split().Select(int.Parse).ToList();
var dp = new int[n,2];
int max = list[0];
dp[0, 0] = list[0]; dp[0,1] = list[0];
for(int i = 1;i < n; i++)
{
    dp[i, 0] = Math.Max(list[i] + dp[i-1, 0], list[i]);
    dp[i, 1] = Math.Max(list[i] + dp[i-1, 1], dp[i-1,0]);
    max = Math.Max(max, Math.Max(dp[i,0], dp[i,1]));
}
Console.WriteLine(max);