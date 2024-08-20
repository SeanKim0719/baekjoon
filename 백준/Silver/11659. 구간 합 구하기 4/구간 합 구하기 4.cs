StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
var input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int N = input[0]; int M = input[1];
var list = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int[] sum = new int[N + 1]; sum[0] = 0;
for(int i = 1; i <= N; i++)
{
    sum[i] = sum[i - 1] + list[i - 1]; // s[1] = list[0] s[2] = s[1] + list[1]
}
for(int i = 0; i < M; i++)
{
    var point = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    sw.WriteLine(sum[point[1]] - sum[point[0]-1]);
}
sr.Close();
sw.Close();