using System.Text;
string str = Console.ReadLine();
string burst = Console.ReadLine();
var sb = new StringBuilder();
foreach (char c in str)
{
    sb.Append(c);
    if(sb.Length >= burst.Length)
    {
        var temp = sb.ToString(sb.Length-burst.Length,burst.Length);
        if(temp == burst) { sb.Remove(sb.Length - burst.Length, burst.Length); }
    }   
}
Console.WriteLine(sb.Length == 0? "FRULA":sb.ToString());