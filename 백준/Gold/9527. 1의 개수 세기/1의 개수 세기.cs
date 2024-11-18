var input = Console.ReadLine().Split().Select(long.Parse).ToList();
long B = input[0],A = input[1];
var bi_cnt = new long[56];
bi_cnt[0] = 1;
for(int i = 1; i < 56; i++)
{
    bi_cnt[i] = bi_cnt[i - 1] * 2 + (1L << i);
}
Console.WriteLine(get_one(A)-get_one(B-1));
long get_one(long x)
{
    long cnt_1 = x&1;
    for (int i = 56; i > 0; i--)
    {
        if ((x & (1L << i)) != 0)
        {
            cnt_1 += bi_cnt[i-1] +x-(1L << i) + 1;
            x -= 1L << i;
        }
    }
    return cnt_1;
}