var n = int.Parse(Console.ReadLine());
var tri = new List<List<int>>();
var DP = new int[n,n];
for (int i = 0; i < n; i++)
{
    tri.Add(new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse)));
}
DP[0, 0] = tri[0][0];
for(int i = 1; i < n; i++)
{
    for(int j = 0; j < i+1; j++)
    {
        if (j == 0) { DP[i, j] = DP[i - 1, j] + tri[i][j]; }
        else if (j == i) { DP[i, j] = DP[i - 1, j - 1] + tri[i][j]; }
        else
        {
            DP[i, j] = tri[i][j] + Math.Max(DP[i - 1, j - 1], DP[i - 1, j]);
        }
        
    }
}
int max = 0;
for(int i = 0; i < n; i++)
{
    max = DP[n - 1, i] > max ? max = DP[n - 1, i] : max;
}
Console.WriteLine(max);