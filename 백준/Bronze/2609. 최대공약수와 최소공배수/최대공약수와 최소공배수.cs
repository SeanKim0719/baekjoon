var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.WriteLine(GCD(input[0], input[1]));
Console.WriteLine(input[0] * input[1] / GCD(input[0], input[1]));
static int GCD(int x, int y)
{
    if (y == 0) return x;
    else return GCD(y, x % y);
}