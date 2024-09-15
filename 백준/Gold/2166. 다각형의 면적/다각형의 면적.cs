var n = int.Parse(Console.ReadLine());
var first = Console.ReadLine().Split().Select(double.Parse).ToArray();
var prev = Console.ReadLine().Split().Select(double.Parse).ToArray();
double ans = 0;
for(int i = 0; i < n-2; i++)
{
    var input = Console.ReadLine().Split().Select(double.Parse).ToArray();
    ans += Area((first[0], prev[0], input[0]), (first[1], prev[1], input[1]));
    prev = input;
}
Console.WriteLine($"{Math.Abs(Math.Round(ans,1)):F1}");
static double Area((double,double,double) x, (double,double,double) y)
{
    double size;
    size = (x.Item1 * y.Item2 + x.Item2 * y.Item3 + x.Item3 * y.Item1 - x.Item2 * y.Item1 - x.Item3 * y.Item2 - x.Item1*y.Item3)*0.5;
    return size;
}