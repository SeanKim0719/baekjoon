var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int n = input[0], k = input[1];
int cnt = 0;
var queue = new Queue<int>();
var visited = new bool[100001];
queue.Enqueue(n);
while (n != k)
{
    int size = queue.Count;
    for (int i = 0; i < size; i++)
    {
        n = queue.Dequeue();
        if (n == k) break;
        if (n + 1 <= 100000 && !visited[n + 1]) {queue.Enqueue(n + 1); visited[n + 1] = true;}
        if (n - 1 >= 0 && !visited[n - 1]) {queue.Enqueue(n - 1); visited[n - 1] = true;}
        if (n * 2 <= 100000 && !visited[n * 2]) {queue.Enqueue(n * 2); visited[n * 2] = true;}
    }
    cnt++;
}
Console.WriteLine(cnt == 0? "0":cnt-1);