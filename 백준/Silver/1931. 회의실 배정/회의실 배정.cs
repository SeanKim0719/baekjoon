var n = int.Parse(Console.ReadLine());
var meeting = new List<(int start,int end)>();
while (n-- > 0)
{
    var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
    meeting.Add((input[0], input[1]));
}
meeting = meeting.OrderBy(x=>x.end).ThenBy(x=>x.start).ToList();
var ans = meeting.Aggregate((end:0,count:0),(acc,current)=>current.start >= acc.end?(current.end,acc.count+1):(acc.end,acc.count));
Console.WriteLine(ans.count);