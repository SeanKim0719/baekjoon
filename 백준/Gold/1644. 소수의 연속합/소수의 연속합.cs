var n = int.Parse(Console.ReadLine());
var prime_check = new int[n+1];
var prime = new List<int>();
var cnt = 0;
for(int i = 2; i <= n; i++)
{
    if (prime_check[i] == 0)
    {
        for(int j = i; j <= n; j+=i)
        {
            prime_check[j] = 1;
        }
        prime.Add(i);
    }
}
int l = 0, r = 0,sum = 0;
while (l <= r && r <= prime.Count)
{
    if (sum == n)
    {
        cnt++; sum -= prime[l]; l++; 
    }
    if (sum > n)
    {
        sum -= prime[l]; l++; 
    }
    if(sum < n)
    {
        if(r == prime.Count) { break; }
        sum += prime[r]; r++;
    }
}
Console.WriteLine(cnt);