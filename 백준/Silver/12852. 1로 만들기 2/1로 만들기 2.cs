var x = int.Parse(Console.ReadLine());
var DP = Enumerable.Repeat(0, x+1).ToArray();
var route = Enumerable.Repeat(1,x+1).ToArray();
var ans = new List<int>();
for (int i = 2; i < DP.Length; i++)
{
    DP[i] = DP[i - 1] + 1;
    route[i] = i - 1;
    if (i % 3 == 0 && DP[i/3]+1 < DP[i]) { DP[i] = DP[i/3]+1; route[i] = i / 3; }
    if (i % 2 == 0 && DP[i/2]+1 < DP[i]) { DP[i] = DP[i/2]+1; route[i] = i / 2; }
}
Console.WriteLine(DP[x]);
ans.Add(x);
while (x != 1)
{
    ans.Add(route[x]);
    x = route[x];
}
Console.WriteLine(string.Join(" ",ans));