int t = int.Parse(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    Console.WriteLine(kai(input[0], input[1], input[2], input[3]));
}
static int kai(int n,int m, int x,int y)
{
    int ans = 0;
    for (int i = 0; i < m; i++)
    {
        ans = x + n * i;
        if ((ans - 1)% m + 1 == y) return ans;
    }
    return -1;
}