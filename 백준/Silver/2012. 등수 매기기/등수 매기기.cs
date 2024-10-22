int n = int.Parse(Console.ReadLine());
var rank = new List<int>();
long ans = 0;
for(int i = 0;i < n; i++)
{
    rank.Add(int.Parse(Console.ReadLine()));
}
rank.Sort();
for(int i = 1; i <= n; i++)
{
    ans += Math.Abs(rank[i-1] - i);
}
Console.WriteLine(ans);