var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int  n = input[0],m = input[1];
var dot = Enumerable.Range(0, n).ToList();
var rank = Enumerable.Repeat(0,n).ToList();
int ans = 0;
for(int i = 0; i < m;i++)
{
    var line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    if (Find(line[0]) == Find(line[1])) { ans = i+1; break; }
    Union(line[0], line[1]);
}
Console.WriteLine(ans == 0?0:ans);
int Find(int x)
{
    if (dot[x] == x) return x;
    return dot[x] = Find(dot[x]);
}
void Union(int x, int y)
{
    x = Find(x);
    y = Find(y);
    if (x == y) return;
    if (rank[x] > rank[y]) { dot[y] = x; }
    else if (rank[x] < rank[y]) { dot[x] = y; }
    else { dot[y] = x; rank[x]++; }
}