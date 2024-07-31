int N = int.Parse(Console.ReadLine());
long[] Liquid = Array.ConvertAll(Console.ReadLine().Split(' '),long.Parse);
Array.Sort(Liquid);
long l; long r; long point;
long min = 3000000001;
(long left, long mid, long right) answer = (0,0,0);
for (l=0; l < N - 2; l++)
{
    r = N - 1; point = l + 1;
    while (point < r)
    {
        long sum = Liquid[l] + Liquid[point] + Liquid[r];
        if (min > Math.Abs(sum))
        {
            min = Math.Abs(sum);
            answer = (Liquid[l], Liquid[point], Liquid[r]);
        }
        if (sum < 0)
        {
            point++;
        }
        else
        {
            r--;
        }
    }
}
Console.WriteLine($"{answer.left} {answer.mid} {answer.right}");