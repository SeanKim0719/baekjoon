using System.Numerics;

var L = int.Parse(Console.ReadLine());
var str = Console.ReadLine();
BigInteger r = 1;
BigInteger sum = 0;
foreach(var item in str)
    {
        sum +=(item - 'a' + 1) * r;
        r *= 31;
    }
Console.WriteLine((sum)%1234567891);