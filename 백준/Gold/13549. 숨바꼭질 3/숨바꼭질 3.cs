const int max = 100001;
const int min = 0;
var input = Console.ReadLine().Split().Select(int.Parse).ToList();
var pq = new PriorityQueue<int,int>();
var visit = Enumerable.Repeat(int.MaxValue, max).ToArray();
visit[input[0]] = 0;
pq.Enqueue(input[0], 0);
while (pq.Count > 0)
{
    int point = pq.Dequeue();
    if (point == input[1])
    {
        break;
    }
    if (point * 2 < max && visit[point*2] > visit[point])
    {
        visit[point * 2] = visit[point];
        pq.Enqueue(point * 2, visit[point*2]);
    }
    if(point + 1 < max && visit[point+1] > visit[point])
    {
        visit[point+1] = visit[point] + 1;
        pq.Enqueue(point + 1, visit[point+1]);
    }
    if(point > min && visit[point - 1] > visit[point])
    {
        visit[point-1] = visit[point] + 1;
        pq.Enqueue(point - 1, visit[point-1]);
    }
}
Console.WriteLine(visit[input[1]]);