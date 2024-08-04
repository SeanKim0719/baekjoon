int N = int.Parse(Console.ReadLine());
Console.WriteLine(DP(N, 1));

static int DP(int N,int recu)
{
    int start = 3 * recu;
    if (start > N)
    {
        return -1;
    }

    for (int i = 0; i < recu + 1; i++)
    {
        if(start == N)
        {
            return recu;
        }
        start += 2;
    }
   
    return DP(N, recu + 1);
}