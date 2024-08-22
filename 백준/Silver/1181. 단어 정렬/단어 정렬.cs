int N = int.Parse(Console.ReadLine());
List<string> list = new List<string>();
for(int i = 0; i < N; i++) list.Add(Console.ReadLine());
Console.WriteLine(string.Join("\n",list.Distinct().OrderBy(x => x.Length).ThenBy(x => x)));