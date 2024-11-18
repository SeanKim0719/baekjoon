var g = int.Parse(Console.ReadLine());
var p = int.Parse(Console.ReadLine());
var root = Enumerable.Range(0, g + 1).ToList();
int cnt = 0;
while(p-->0)
{
    var gate = int.Parse(Console.ReadLine());
    gate = Find(gate);
    if (gate == 0) break;
    Union(gate, gate - 1);
    cnt++;
}
Console.WriteLine(cnt);
int Find(int x)
{
    if (x == root[x]) return x;
    return root[x] = Find(root[x]);
}
void Union(int x,int y)
{
    x = Find(x);y = Find(y);
    if(x == y) return;
    root[x] = y;
}