long[] tri = new long[105];
tri[0] = 1; tri[1] = 1; tri[2] = 1; tri[3] = 2; tri[4] = 2;
for(int i = 5; i < 101; i++)
{
    tri[i] = tri[i - 1] + tri[i - 5];
}
int T = int.Parse(Console.ReadLine());
for(int i = 0; i < T; i++)
{
    Console.WriteLine(tri[int.Parse(Console.ReadLine())-1]);
}