const int num = 10007;
var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
var dp = new int[1005, 1005];
dp[1, 1] = 1; dp[1, 2] = 1;
for (int i = 2; i <= input[0]; i++)
{
    for (int j = 1; j <= i+1; j++)
    {
        dp[i, j] = (dp[i - 1, j - 1] + dp[i - 1, j])%num;
    }
}
Console.WriteLine(dp[input[0],input[1]+1]);