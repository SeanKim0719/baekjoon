int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    long sum = 0;
    var n = int.Parse(Console.ReadLine());
    var days = Console.ReadLine().Split().Select(int.Parse).ToList();
    int max = days.Last();
    for(int j = n-1; j >= 0; j--)
    {
        if (days[j] < max) { sum += max - days[j]; }
        else if (days[j] > max) { max = days[j]; }
    }
    Console.WriteLine(sum);
}