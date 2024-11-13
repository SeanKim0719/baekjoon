var n = int.Parse(Console.ReadLine());
var tree = Enumerable.Range(0,n+1).Select(x=>new List<int>()).ToList();
var ans = new int[n + 1];
while (n-- > 1)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    tree[input[0]].Add(input[1]);
    tree[input[1]].Add(input[0]);
}
dfs(1);
Console.WriteLine(string.Join("\n",ans.Skip(2)));
void dfs(int parent)
{
    foreach(var x in tree[parent])
    {
        tree[x].Remove(parent);
        ans[x] = parent;
        dfs(x);
    }
}