using System.Numerics;
var t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    var input = Array.ConvertAll(Console.ReadLine().Split(),BigInteger.Parse);
    Console.WriteLine(BigInteger.ModPow(input[0], input[1], 10) == 0 ? 10: BigInteger.ModPow(input[0], input[1], 10));
}