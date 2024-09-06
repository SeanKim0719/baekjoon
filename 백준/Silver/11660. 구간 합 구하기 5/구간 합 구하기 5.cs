StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
var input = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
int n = input[0],m = input[1];
var arr = new List<List<int>>();
var DP = new int[n+1,n+1];
for (int i = 0; i < n; i++)
{
    arr.Add(new List<int>(Array.ConvertAll(sr.ReadLine().Split(), int.Parse)));
}
for(int i = 1; i <= n; i++)
{
    for(int j = 1; j <= n; j++)
    {
        DP[i, j] = DP[i - 1, j] + DP[i, j - 1] + arr[i-1][j-1] - DP[i - 1,j - 1];
    }
}
for(int i = 0; i < m; i++)
{
    var x = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    sw.WriteLine(DP[x[2], x[3]] - DP[x[0]-1,x[3]] - DP[x[2], x[1] - 1] + DP[x[0] - 1, x[1]-1]);
}
sr.Close();
sw.Close();