var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int n = input[0],m = input[1];
var mem = Enumerable.Range(0, n + 1).ToArray();
var truth = Console.ReadLine().Split().Select(int.Parse).ToArray();
var partys = new List<List<int>>();
int ans = m;
for (int i = 1; i < truth.Length; i++)
{
    mem[truth[i]] = 0;
}
while(m-- > 0)
{
    partys.Add(Console.ReadLine().Split().Select(int.Parse).ToList());
} 
foreach(var party in partys)
{
    for(int i = 1; i < party.Count-1; i++)
    {
        Union(party[i], party[i+1]);
    }
}
foreach(var party in partys)
{
    for(int i = 1; i < party.Count; i++)
    {
        if (Find(party[i]) == 0)
        {
            ans--;
            break;
        }
    }
}
Console.WriteLine(ans);
int Find(int x)
{
    if (mem[x] == x)
    {
        return x;
    }
    else
    {
        return mem[x] = Find(mem[x]);
    }
}

void Union(int x,int y)
{
    x = Find(x);
    y = Find(y);
    if (x == y) return;
    else
    {
        if(x < y) { mem[y] = x; }
        else { mem[x] = y; }
    }
}