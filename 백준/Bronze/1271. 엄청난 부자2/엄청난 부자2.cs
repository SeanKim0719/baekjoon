using System.Numerics;
var input = Array.ConvertAll(Console.ReadLine().Split(), BigInteger.Parse);
var n = input[0];
var m = input[1];
Console.WriteLine(n / m);
Console.WriteLine(n % m);