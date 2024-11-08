var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = input[0],m = input[1];
var pre = Enumerable.Range(0,n+1).Select(x=>new List<int>()).ToList();
var rank = Enumerable.Repeat(0,n+1).ToArray();
var pq = new PriorityQueue<int, int>();
var ans = new List<int>();
for(int i = 0; i < m; i++)
{
    var info = Console.ReadLine().Split().Select(int.Parse).ToList();
    pre[info[0]].Add(info[1]);
    rank[info[1]]++;
}
for(int i = 1; i <= n; i++)
{
    if (rank[i] == 0) { pq.Enqueue(i, i); }
    
}
while (pq.Count > 0)
{
    var solve = pq.Dequeue();
    ans.Add(solve);
    if (pre[solve].Count > 0)
    {
        foreach(var i in pre[solve])
        {
            rank[i]--;
            if (rank[i] == 0) { pq.Enqueue(i, i); }
        }
    }
}
Console.WriteLine(string.Join(" ",ans));