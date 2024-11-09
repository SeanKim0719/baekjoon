var t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    var str = Console.ReadLine();
    var stack = new Stack<char>();
    foreach (var s in str)
    {
        try { if (s == ')') { stack.Pop(); continue; } }
        catch { stack.Push('x'); break; }
        stack.Push(s);
    }
    Console.WriteLine(stack.Count == 0 ? "YES":"NO");
}