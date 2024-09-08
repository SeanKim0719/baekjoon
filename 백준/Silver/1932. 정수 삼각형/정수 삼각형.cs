var n = int.Parse(Console.ReadLine());
var tri = new List<List<int>>();
var DP = new List<List<int>>();
for (int i = 0; i < n; i++)
{
    tri.Add(new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse)));
}
for(int i = 1; i < n; i++)
{
    for(int j = 0; j < i+1; j++)
    {
        if (j == 0) { tri[i][j] = tri[i - 1][j] + tri[i][j]; }
        else if (j == i) { tri[i][j] = tri[i - 1][j - 1] + tri[i][j]; }
        else
        {
            tri[i][j] = tri[i][j] + Math.Max(tri[i - 1][j - 1], tri[i - 1][j]);
        }
        
    }
}
Console.WriteLine(tri[^1].Max());