var n = int.Parse(Console.ReadLine());
var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
var dp = Enumerable.Repeat(1,n).ToArray();
for(int i = 1; i < n; i++)
{
    for (int j = i-1; j >= 0; j--)
    {
        if (arr[i] > arr[j])
        {
            dp[i] = Math.Max(dp[j] + 1, dp[i]);
        }
    }
}
Console.WriteLine(dp.Max());