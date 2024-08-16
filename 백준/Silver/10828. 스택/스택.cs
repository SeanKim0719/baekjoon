StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
Stack<int> stack = new Stack<int>();

int N = int.Parse(Console.ReadLine());
for(int i = 0; i < N; i++)
{
    var input = Console.ReadLine().Split();
    int p = 0;
    if (input.Length > 1) p = int.Parse(input[1]);
    string com = input[0];
    switch (com)
    {
        case "push":
            push(p, stack); break;
        case "pop":
            sw.WriteLine(pop(stack)); break;
        case "size":
            sw.WriteLine(size(stack)); break;
        case "empty":
            sw.WriteLine(empty(stack)); break;
        case "top":
            sw.WriteLine(top(stack)); break;
        default: break;
    }
}
sr.Close();
sw.Close();
static void push(int i,Stack<int> stack)
{
    stack.Push(i);
}
static int pop(Stack<int> stack)
{
    if (stack.Count == 0) return -1;
    else return stack.Pop();
}

static int size(Stack<int> stack)
{
    return stack.Count;
}

static int empty(Stack<int> stack)
{
    if (stack.Count == 0) return 1;
    else return 0;
}

static int top(Stack<int> stack)
{
    if (stack.Count == 0) return -1;
    else
    {
        int n = stack.Pop();
        stack.Push(n);
        return n;
    }
}