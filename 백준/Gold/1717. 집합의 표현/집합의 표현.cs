StreamWriter sw = new(Console.OpenStandardOutput());
var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = input[0], m = input[1];
var set = Enumerable.Range(0, n + 1).ToArray();
var rank = Enumerable.Repeat(0, n + 1).ToArray();
for (int i = 0; i < m; i++)
{
    var ope = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    if (ope[0] == 0)
    {
        if (Find(ope[1]) != Find(ope[2])) { Union(ope[1], ope[2]); }
    }
    else
    {
        sw.WriteLine(Find(ope[1]) == Find(ope[2]) ? "YES" : "NO");
    }
}
sw.Close();
int Find(int x)
{
    if (set[x] == x)
    {
        return x;
    }
    else
    {
        return set[x] = Find(set[x]);
    }
}

void Union(int x, int y)
{
    x = Find(x);
    y = Find(y);
    if (x == y)
    {
        return;
    }
    if (rank[x] > rank[y])
    {
        set[y] = x; rank[y] = rank[x];
    }
    else if (rank[x] < rank[y])
    {
        set[x] = y; rank[y] = rank[x];
    }
    else
    {
        set[y] = x; rank[x]++; rank[y] = rank[x];
    }
}