var n = int.Parse(Console.ReadLine());
var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
var v = int.Parse(Console.ReadLine());
Console.WriteLine(arr.Where(x => x == v).Count());