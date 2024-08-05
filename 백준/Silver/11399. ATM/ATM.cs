int N = int.Parse(Console.ReadLine());
var time = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int sum = 0;
Array.Sort(time);
for(int i = 0; i < N-1; i++)
{
    time[i + 1] += time[i];
    sum += time[i];
}
Console.WriteLine(sum += time.Last());