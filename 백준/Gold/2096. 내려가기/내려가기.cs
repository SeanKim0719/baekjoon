var n = int.Parse(Console.ReadLine());
var Dp = new (int min,int max)[3];
var input = Console.ReadLine().Split().Select(int.Parse).ToList();
for (int i = 0; i < 3; i++) {Dp[i] = (input[i], input[i]);}
while (--n > 0)
{
    var arr = Console.ReadLine().Split().Select(int.Parse).ToList();
    var newDp = new (int min, int max)[3];
    newDp[0] = (Math.Min(Dp[0].min, Dp[1].min) + arr[0], Math.Max(Dp[0].max, Dp[1].max) + arr[0]);
    newDp[1] = (Math.Min(Math.Min(Dp[0].min, Dp[1].min), Dp[2].min) + arr[1], Math.Max(Math.Max(Dp[0].max, Dp[1].max), Dp[2].max) + arr[1]);
    newDp[2] = (Math.Min(Dp[1].min, Dp[2].min) + arr[2], Math.Max(Dp[1].max, Dp[2].max) + arr[2]);
    Dp = newDp;
}
Console.WriteLine($"{Dp.Max(x=>x.max)} {Dp.Min(x=>x.min)}");