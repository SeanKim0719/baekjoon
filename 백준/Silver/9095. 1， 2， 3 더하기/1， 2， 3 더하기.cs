int t = int.Parse(Console.ReadLine());
var DP = new int[11];
DP[1] = 1; DP[2] = 2; DP[3] = 4;
for(int i = 4; i < 11; i++)
{
    DP[i] = DP[i - 1] + DP[i - 2] + DP[i - 3];
}
for(int i = 0; i < t; i++)
{
    var input = int.Parse((Console.ReadLine()));
    Console.WriteLine(DP[input]);
}