using System.Text;
var infix = Console.ReadLine();
var op = new Stack<char>();
var postfix = new StringBuilder();
foreach(var c in infix)
{
    if(c >= 'A'&&c <= 'Z') { postfix.Append(c); continue; }
    if (c == ')')
    {
        while (op.Peek() != '(' && op.Count != 0) { postfix.Append(op.Pop()); }
        op.Pop(); continue;
    }
    if (c == '*' || c == '/')
    {
        while (op.Count != 0 && (op.Peek() == '*' || op.Peek() == '/')) { postfix.Append(op.Pop());}
    }
    if(c == '-' || c == '+') 
    {
        while (op.Count != 0 && op.Peek() != '(') { postfix.Append(op.Pop()); }
    }
    op.Push(c);
}
postfix.Append(new string(op.ToArray()));
Console.WriteLine(postfix);