StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
int N = int.Parse(sr.ReadLine());
var age = Enumerable.Range(0, 201).Select(x => new List<string> { x.ToString() }).ToList();
for (int i = 0; i < N; i++)
{
    var input = sr.ReadLine().Split();
    age[int.Parse(input[0])].Add(input[1]); // age[21] = "21""JUNKUK"
}
var ans = age.Where(x => x.Count() > 1);
foreach (var x in ans)
{
    for (int i = 1; i < x.Count; i++)
    {
        sw.WriteLine($"{x[0]} {x[i]}");
    }
}
sr.Close();
sw.Close();