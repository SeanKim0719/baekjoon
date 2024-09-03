var N = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
var prime = Enumerable.Range(0, N[1]+1).ToArray();
prime[1] = 0;
for(int i = prime[2]; i < N[1]; i++)
{
    if (prime[i] != 0)
    {
        int j = 2;
        while(j*i <= N[1])
        {
            if (prime[j * i] != 0) prime[j * i] = 0; j++;
        }
    }
}
var ans = prime.Where(x => x >= N[0] && x != 0).ToArray();
Console.WriteLine(string.Join("\n",ans));