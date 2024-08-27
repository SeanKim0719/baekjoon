int n = int.Parse(Console.ReadLine());
var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] ans = Enumerable.Repeat(-1, n).ToArray<int>();
var stack = new Stack<int>();
for (int i = 0; i < n; i++)
{
    while (stack.Count != 0 && input[stack.Peek()] < input[i])
    {
        ans[stack.Peek()] = input[i];
        stack.Pop();
    }
    stack.Push(i);
}
Console.WriteLine(string.Join(" ",ans));
