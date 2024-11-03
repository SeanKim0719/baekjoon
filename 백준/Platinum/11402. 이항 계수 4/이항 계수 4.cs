var input = Console.ReadLine().Split().Select(long.Parse).ToList();
long n = input[0], k = input[1],m = input[2];
var upper = Trans(n,m);
var lower = Trans(k,m);
Console.WriteLine(Lucas(upper,lower));

List<long> Trans(long n,long m)
{
    var x = new List<long>();
    while (n > 0) { x.Add(n%m);n /= m; }
    return x;
}
long Lucas(List<long>x,List<long>y)
{
    long ans = 1;
    for (int i = 0; i < x.Count; i++)
    {
        long xi = x[i];
        long yi = (i < y.Count) ? y[i] : 0;
        if (x[i] < yi) { ans = 0; return ans; }
        ans = ans*Bino(xi, yi)%m;
    }
    return ans;
}
long Bino(long x,long y)
{
    var dp = new long[x + 1, x + 1];
    for (int i = 0; i <= x; i++)
    {
        dp[i, 0] = 1;
        dp[i, i] = 1;
        for (int j = 1; j < i; j++)
        {
            dp[i, j] = (dp[i - 1, j - 1] + dp[i - 1, j]) % m;
        }
    }
    return dp[x, y];
}