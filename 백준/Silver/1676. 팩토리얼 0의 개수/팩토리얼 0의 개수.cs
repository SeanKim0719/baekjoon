int N = int.Parse(Console.ReadLine());
int M = 1;
int cnt = 0;
while (N >= M)
{
    double temp = M;
    while(temp / 5 > 0)
    {
        if(temp % 5 == 0)
        {
            cnt++;
        }
        temp /= 5;
    }
    M++;
}
Console.WriteLine(cnt);