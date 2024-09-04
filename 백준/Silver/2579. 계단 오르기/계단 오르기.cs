var n = int.Parse(Console.ReadLine());
var stair = new List<int>();
var ans = new int[n];
for (int i = 0; i < n; i++)
{
    stair.Add(int.Parse(Console.ReadLine()));
}
switch (n)
{
    case 1: ans[0] = stair[0];break;
    case 2: ans[1] = stair[1]+ stair[0]; break;
    case 3: ans[2] = stair[2] + Math.Max(stair[0], stair[1]); break;
    default: ans[0] = stair[0]; ans[1] = stair[1] + stair[0]; ans[2] = stair[2] + Math.Max(stair[0], stair[1]);break;
}
for(int i = 3; i < n; i++)
{
    ans[i] = stair[i] + Math.Max(ans[i - 3] + stair[i-1], ans[i - 2]) ;
}
Console.WriteLine(ans[n-1]);