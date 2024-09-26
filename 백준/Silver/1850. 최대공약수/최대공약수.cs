using System.Text;

var input = Array.ConvertAll(Console.ReadLine().Split(),long.Parse);
long a = input[0],b = input[1];
var gcd = GCD(a, b);
var sb = new StringBuilder();
while (gcd-- > 0)
{
    sb.Append(1);
}
Console.WriteLine(sb);
static long GCD(long x, long y)
{
    if (y == 0) return x;
    else return GCD(y, x % y);
}