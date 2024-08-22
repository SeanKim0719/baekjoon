var n = int.Parse(Console.ReadLine());
var coord = new List<(int, int)>();
for(int i = 0; i < n; i++)
{
    var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
    coord.Add((input[0], input[1]));
}
var ans = coord.OrderBy(x => x.Item2).ThenBy(x => x.Item1);
Console.WriteLine(string.Join("\n",ans.Select(x => $"{x.Item1} {x.Item2}")));