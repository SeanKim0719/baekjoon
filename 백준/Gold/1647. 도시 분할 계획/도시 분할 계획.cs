var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = input[0],m = input[1];
var set = Enumerable.Range(0,n+1).ToList();
var rank = Enumerable.Repeat(0,n+1).ToList();
var pq = new PriorityQueue<(int x,int y,int weight),int>();
var uni = n;
var sum = 0;
while (m-- > 0)
{
    var line = Console.ReadLine().Split().Select(int.Parse).ToList();
    pq.Enqueue((line[0], line[1], line[2]), line[2]);
}
while (uni > 2)
{
    var output = pq.Dequeue();
    if (Find(output.x) != Find(output.y))
    {
        Union(output.x, output.y);
        uni--;
        sum += output.weight;
    }
}
Console.WriteLine(sum);
int Find(int x)
{
    if (set[x] == x) return x;
    else
    {
        return set[x] = Find(set[x]);
    }
}
void Union(int x, int y)
{
    x = Find(x);
    y = Find(y);
    if(x==y) return;
    if (rank[x] > rank[y])
    {
        set[y] = x;
    }
    else if (rank[x] < rank[y])
    {
        set[x] = y;
    }
    else
    {
        set[y] = x; rank[x]++;
    }
}