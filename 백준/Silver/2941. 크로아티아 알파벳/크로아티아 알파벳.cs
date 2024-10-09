var alp = new[] { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
var input = Console.ReadLine();
foreach(var item in alp)
{
    input = input.Replace(item, "1");
}
Console.WriteLine(input.Length);