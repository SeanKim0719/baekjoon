StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
var que = new Queue<int>();
int t = int.Parse(sr.ReadLine());
while (t > 0)
{
    var input = sr.ReadLine().Split();
    string op; int point = 0;
    if (input.Length > 1) { op = input[0]; point = int.Parse(input[1]); }
    else { op = input[0]; }
    switch (op)
    {
        case "push" : Push(point, que); break;
        case "pop": sw.WriteLine(Pop(que)); break;
        case "size": sw.WriteLine(Size(que)); break;
        case "empty": sw.WriteLine(Empty(que)); break;
        case "front": sw.WriteLine(Front(que)); break;
        case "back": sw.WriteLine(Back(que)); break;
        default: break;
    }
    t--;
}
sr.Close();
sw.Close();
static void Push(int x, Queue<int> queue) { queue.Enqueue(x); }
static int Pop(Queue<int> queue)
{
    if (queue.Count == 0) return -1;
    else return queue.Dequeue();
}
static int Size(Queue<int> queue) { return queue.Count(); }
static int Empty(Queue<int> queue)
{
    if (queue.Count != 0) return 0;
    else return 1;
}
static int Front(Queue<int> queue)
{
    if (queue.Count == 0) return -1;
    else return queue.Peek();
}
static int Back(Queue<int> queue)
{
    if (queue.Count == 0) return -1;
    else return queue.Last();
}