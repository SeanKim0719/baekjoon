var input = new List<List<int>>();
for(int i = 0; i < 9; i++)
{
    input.Add(new List<int>(Console.ReadLine().Split().Select(int.Parse)));
}
var ans = input.SelectMany(x=>x).ToList().Max();
var point = input.SelectMany(x => x).TakeWhile(x => x != ans).Count();
Console.WriteLine(ans);
Console.WriteLine($"{point/9 + 1} {point%9 + 1}");