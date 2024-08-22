StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
int N = int.Parse(sr.ReadLine());
var coord = new List<(int,int)>();
for (int i = 0; i < N; i++)
{
    var input = sr.ReadLine().Split().Select(int.Parse);
    coord.Add((input.First(),input.Last()));
}
var ans = coord.OrderBy(x => x.Item1).ThenBy(x => x.Item2);
foreach (var x in ans)
{
    sw.WriteLine($"{x.Item1} {x.Item2}");
}
sr.Close();
sw.Close();