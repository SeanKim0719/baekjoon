int T = int.Parse(Console.ReadLine());
int[,] ans = new int[15, 15];
for(int k = 1; k < 15; k++)
{
    ans[0, k] = k;
    ans[k, 1] = 1;
}
for(int i = 1; i < 15; i++)
{
    for (int j = 2; j < 15; j++)
    {
        ans[i, j] = ans[i-1,j] + ans[i,j-1];
    }
}


for (int i = 0; i < T; i++)
{
    int K = int.Parse(Console.ReadLine());
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine(ans[K,n]);
}