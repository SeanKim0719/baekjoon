string str = Console.ReadLine();
string burst = Console.ReadLine();
var check = new Stack<char>();
foreach (char c in str)
{
    check.Push(c);
    if(check.Count >= burst.Length)
    {
        var temp = new List<char>();
        for (int i = 0; i < burst.Length; i++) { temp.Add(check.Pop()); }
        temp.Reverse();
        if (new string(temp.ToArray()) != burst)
        {
            foreach (var t in temp)
            {
                check.Push(t);
            }
        }
    }   
}
Console.WriteLine(check.Count == 0? "FRULA":new string(check.Reverse().ToArray()));