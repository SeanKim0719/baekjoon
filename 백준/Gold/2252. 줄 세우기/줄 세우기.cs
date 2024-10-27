var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int n = input[0],m = input[1];
var node = Enumerable.Range(0,n+1).Select(x => new List<int>()).ToList();
var rank = new int[n+1];
var que = new Queue<int>();
var ans = new List<int>();
for(int i = 0; i < m; i++)
{
    var ord = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
    node[ord[0]].Add(ord[1]);
    rank[ord[1]]++;
}
for (int i = 1; i < n+1; i++)
{
    if (rank[i] == 0) { que.Enqueue(i);}
}
while (que.Count > 0)
{
    var point = que.Dequeue();
    ans.Add(point);
    foreach (var item in node[point])
    {
        rank[item]--;
        if(rank[item] == 0) {que.Enqueue(item); }
    }
}
Console.WriteLine(string.Join(" ",ans));