var n = int.Parse(Console.ReadLine());
var house = new List<List<int>>();
var ans = new int[n,3];
for (int i = 0; i < n; i++)
{
    house.Add(Console.ReadLine().Split().Select(int.Parse).ToList());
}
for(int i = 0; i < 3; i++)
{
    ans[0, i] = house[0][i];
}
for(int i = 1; i < n; i++)
{
    for(int j = 0; j < 3; j++)
    {
        ans[i, j] = Math.Min(ans[i - 1,(j+1)%3], ans[i - 1,(j+2)%3]) + house[i][j];
    }
}
int min = Enumerable.Range(0, 3).Min(i => ans[n-1,i]);
Console.WriteLine(min);