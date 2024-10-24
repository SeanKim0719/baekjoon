using System.Numerics;
BigInteger a = BigInteger.Parse(Console.ReadLine());
BigInteger b = BigInteger.Parse(Console.ReadLine());
BigInteger[] ans = {a+b,a-b,a*b};
Console.WriteLine(string.Join("\n",ans));