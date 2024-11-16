var t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToList();
    var n = input[0]; var k = input[1];
    var build = new int[n + 1];
    var time = Console.ReadLine().Split().Select(int.Parse).ToList();
    var queue = new Queue<int>();
    var order = Enumerable.Range(0, n + 1).Select(x => new List<int>()).ToList();
    var ans = new int[n+1];
    for (int i = 0; i < k; i++)
    {
        var ord = Console.ReadLine().Split().Select(int.Parse).ToList();
        order[ord[0]].Add(ord[1]);
        build[ord[1]]++;
    }
    var target = int.Parse(Console.ReadLine());
    for(int i = 1; i <= n; i++)
    {
        if (build[i] == 0) { queue.Enqueue(i); }
    }
    while(queue.Count > 0)
    {
        var point = queue.Dequeue();
        ans[point] = Math.Max(ans[point],time[point - 1]);
        foreach(var x in order[point]) 
        {
            build[x]--;
            ans[x] = Math.Max(ans[x], ans[point] + time[x-1]);
            if (build[x] == 0) { queue.Enqueue(x); }
        }
        if (point == target) break;
    }
    Console.WriteLine(ans[target]);
}