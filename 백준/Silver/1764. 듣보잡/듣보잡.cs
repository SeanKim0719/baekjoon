var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
List<string> listen = new List<string>();
List<string> seen = new List<string>();

for (int i = 0; i < input[0]; i++) listen.Add(Console.ReadLine());
for (int i = 0; i < input[1]; i++) seen.Add(Console.ReadLine());

var ans = from name1 in listen
          join name2 in seen
          on name1 equals name2
          orderby name1
          select name1;

Console.WriteLine($"{ans.Count()}\n{string.Join("\n",ans)}");