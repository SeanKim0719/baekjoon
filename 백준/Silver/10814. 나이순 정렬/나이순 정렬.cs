StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
int N = int.Parse(sr.ReadLine());
var age = new List<(int, string)>();
for(int i = 0; i < N; i++)
{
    var input = sr.ReadLine().Split();
    age.Add((int.Parse(input[0]), input[1]));
}
var ans = age.OrderBy(x => x.Item1);
foreach (var x in ans)
{
    sw.WriteLine($"{x.Item1} {x.Item2}");
}
sr.Close();
sw.Close();