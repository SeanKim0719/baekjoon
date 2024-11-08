var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int n = input[0],m = input[1];
var pre = Enumerable.Range(0,n+1).Select(x=>new List<int>()).ToList();
var rank = Enumerable.Repeat(0,n+1).ToArray();
var pq = new PriorityQueue<int, int>();
var ans = new List<int>();
while(m-- > 0)
{
    var info = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
    pre[info[0]].Add(info[1]);
    rank[info[1]]++;
}
for (int i = 1; i <= n; i++) { if (rank[i] == 0) { pq.Enqueue(i, i); } }
while (pq.Count > 0)
{
    var solve = pq.Dequeue();
    ans.Add(solve);
    foreach (var i in pre[solve])
    {
        rank[i]--;
        if (rank[i] == 0) { pq.Enqueue(i, i); }
    }
}
Console.WriteLine(string.Join(" ",ans));