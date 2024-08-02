StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

Stack<int> stack = new Stack<int>();
var K = int.Parse(sr.ReadLine());
int sum = 0;
for(int i = 0; i < K; i++)
{
    int input = int.Parse(sr.ReadLine());
    if (input == 0)
    {
        stack.Pop();
    }
    else { stack.Push(input); }
}

while(stack.Count > 0)
{
    sum += stack.Pop();
}

sw.WriteLine(sum);
sw.Close();